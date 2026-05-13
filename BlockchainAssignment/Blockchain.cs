using System;
using System.Collections.Generic;
using System.Linq;

namespace BlockchainAssignment
{
    class Blockchain
    {
        // List of blocks in the blockchain
        public List<Block> blocks = new List<Block>();

        // Transaction pool
        public List<Transaction> pendingTransactions = new List<Transaction>();

        // Dynamic difficulty settings
        public float currentDifficulty = 4;
        public double targetBlockTime = 5;

        // Constructor - creates Genesis block automatically
        public Blockchain()
        {
            blocks.Add(new Block());
        }

        // Add a new block to the blockchain
        public void AddBlock(string minerAddress, string preference)
        {
            Block lastBlock = GetLastBlock();

            List<Transaction> chosenTransactions = new List<Transaction>();

            if (preference == "Greedy")
            {
                chosenTransactions = pendingTransactions
                    .OrderByDescending(t => t.fee)
                    .Take(5)
                    .ToList();
            }
            else if (preference == "Altruistic")
            {
                chosenTransactions = pendingTransactions
                    .OrderBy(t => t.timestamp)
                    .Take(5)
                    .ToList();
            }
            else if (preference == "Random")
            {
                Random random = new Random();

                chosenTransactions = pendingTransactions
                    .OrderBy(t => random.Next())
                    .Take(5)
                    .ToList();
            }
            else if (preference == "Address Preference")
            {
                chosenTransactions = pendingTransactions
                    .OrderByDescending(t => t.senderAddress == minerAddress || t.recipientAddress == minerAddress)
                    .ThenByDescending(t => t.fee)
                    .Take(5)
                    .ToList();
            }
            else
            {
                chosenTransactions = pendingTransactions
                    .Take(5)
                    .ToList();
            }

            Block newBlock = new Block(
                lastBlock.hash,
                lastBlock.index,
                chosenTransactions,
                minerAddress,
                currentDifficulty
            );

            blocks.Add(newBlock);

            // Dynamically adjust difficulty
            AdjustDifficulty(newBlock);

            pendingTransactions = pendingTransactions.Except(chosenTransactions).ToList();
        }

        // Read a specific block
        public string ReadBlock(int blockIndex)
        {
            return blocks[blockIndex].PrintBlock();
        }

        // Get the latest block in the chain
        public Block GetLastBlock()
        {
            return blocks[blocks.Count - 1];
        }

        // Read all blocks in the blockchain
        public string ReadAllBlocks()
        {
            string output = "";

            foreach (Block block in blocks)
            {
                output += block.PrintBlock();
                output += "\n\n";
            }

            return output;
        }

        // Read all pending transactions in the transaction pool
        public string ReadPendingTransactions()
        {
            string output = "Pending Transactions: " + pendingTransactions.Count;

            foreach (Transaction transaction in pendingTransactions)
            {
                output += "\n\n" + transaction.PrintTransaction();
            }

            return output;
        }

        // Validate blockchain structure
        public string ValidateChain()
        {
            for (int i = 1; i < blocks.Count; i++)
            {
                Block currentBlock = blocks[i];
                Block previousBlock = blocks[i - 1];

                if (currentBlock.prevHash != previousBlock.hash)
                {
                    return "Blockchain validation failed: block " + i +
                           " has an invalid previous hash.";
                }

                string recalculatedMerkleRoot =
                    Block.CalculateMerkleRoot(currentBlock.transactions);

                if (currentBlock.merkleRoot != recalculatedMerkleRoot)
                {
                    return "Blockchain validation failed: block " + i +
                           " has an invalid Merkle Root.";
                }

                string target = new string('0', (int)currentBlock.difficulty);

                if (!currentBlock.hash.StartsWith(target))
                {
                    return "Blockchain validation failed: block " + i +
                           " does not satisfy Proof-of-Work.";
                }

                string recalculatedBlockHash = currentBlock.CreateHash();

                if (currentBlock.hash != recalculatedBlockHash)
                {
                    return "Blockchain validation failed: block hash mismatch in block " + i + ".";
                }

                foreach (Transaction transaction in currentBlock.transactions)
                {
                    string recalculatedHash = transaction.CreateHash();

                    if (transaction.hash != recalculatedHash)
                    {
                        return "Blockchain validation failed: transaction hash mismatch in block " + i + ".";
                    }

                    if (transaction.senderAddress != "Mine Rewards")
                    {
                        bool validSignature = Wallet.Wallet.ValidateSignature(
                            transaction.senderAddress,
                            transaction.hash,
                            transaction.signature
                        );

                        if (!validSignature)
                        {
                            return "Blockchain validation failed: invalid digital signature in block " + i + ".";
                        }
                    }
                }
            }

            return "Blockchain validation successful: all blocks are correctly linked.";
        }


        // Adjust mining difficulty dynamically
        public void AdjustDifficulty(Block minedBlock)
        {
            // If mining was too fast, increase difficulty
            if (minedBlock.miningTimeSeconds < targetBlockTime)
            {
                currentDifficulty += 0.25f;
            }
            // If mining was too slow, decrease difficulty
            else if (minedBlock.miningTimeSeconds > targetBlockTime)
            {
                currentDifficulty -= 0.25f;
            }

            // Prevent difficulty becoming too low
            if (currentDifficulty < 1)
            {
                currentDifficulty = 1;
            }

            // Prevent difficulty becoming too high
            if (currentDifficulty > 6)
            {
                currentDifficulty = 6;
            }
        }

        // Calculate the balance of a wallet address
        public double GetBalance(string walletAddress)
        {
            double balance = 0;

            foreach (Block block in blocks)
            {
                foreach (Transaction transaction in block.transactions)
                {
                    if (transaction.recipientAddress == walletAddress)
                    {
                        balance += transaction.amount;
                    }

                    if (transaction.senderAddress == walletAddress)
                    {
                        balance -= transaction.amount;
                        balance -= transaction.fee;
                    }
                }
            }

            return balance;
        }
    }
}