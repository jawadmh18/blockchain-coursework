using BlockchainAssignment.HashCode;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace BlockchainAssignment
{
    class Block
    {
        public DateTime timestamp;
        public int index;
        public string hash;
        public string prevHash;
        public string merkleRoot;
        public double miningTimeSeconds = 0;

        // Proof-of-Work variables
        public int nonce = 0;
        public float difficulty = 4;

        public double reward = 25;
        public double fees = 0;
        public string minerAddress;

        // Transactions stored inside the block
        public List<Transaction> transactions = new List<Transaction>();

        // Genesis block constructor (first block)
        public Block()
        {
            timestamp = DateTime.Now;
            prevHash = "";
            index = 0;

            // Genesis block starts with no transactions
            transactions = new List<Transaction>();

            // Calculate Merkle Root
            merkleRoot = CalculateMerkleRoot(transactions);

            // Mine the block
            Mine();
        }

        // Normal block constructor (uses previous block info)
        public Block(
            string prevHash,
            int prevIndex,
            List<Transaction> transactions,
            string minerAddress,
            float difficulty
        )
        {
            timestamp = DateTime.Now;
            this.prevHash = prevHash;
            index = prevIndex + 1;

            this.transactions = transactions;

            // Set dynamic difficulty
            this.difficulty = difficulty;

            // Add mining reward
            AddRewardTransaction(minerAddress);

            // Calculate Merkle Root
            merkleRoot = CalculateMerkleRoot(this.transactions);

            // Mine the block
            Mine();
        }

        // Creates the SHA-256 hash for this block
        public string CreateHash()
        {
            SHA256 hasher = SHA256Managed.Create();

            string input =
                index.ToString() +
                timestamp.ToString() +
                prevHash +
                nonce.ToString() +
                difficulty.ToString() +
                merkleRoot;

            byte[] hashByte = hasher.ComputeHash(
                Encoding.UTF8.GetBytes(input)
            );

            string hash = string.Empty;

            foreach (byte x in hashByte)
            {
                hash += string.Format("{0:x2}", x);
            }

            return hash;
        }

        // Proof-of-Work mining method
        public void Mine()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string target = new string('0', (int)difficulty);

            hash = CreateHash();

            while (!hash.StartsWith(target))
            {
                nonce++;
                hash = CreateHash();
            }

            stopwatch.Stop();

            miningTimeSeconds = stopwatch.Elapsed.TotalSeconds;
        }

        // Calculate Merkle Root from transactions
        public static string CalculateMerkleRoot(List<Transaction> transactions)
        {
            // No transactions
            if (transactions == null || transactions.Count == 0)
            {
                return "";
            }

            // Create list of transaction hashes
            List<string> hashes = new List<string>();

            foreach (Transaction transaction in transactions)
            {
                hashes.Add(transaction.hash);
            }

            // Keep combining hashes until only one remains
            while (hashes.Count > 1)
            {
                List<string> newHashes = new List<string>();

                for (int i = 0; i < hashes.Count; i += 2)
                {
                    // If there are 2 hashes available
                    if (i + 1 < hashes.Count)
                    {
                        newHashes.Add(
                            HashTools.CombineHash(hashes[i], hashes[i + 1])
                        );
                    }
                    else
                    {
                        // Odd number of hashes - keep last one
                        newHashes.Add(hashes[i]);
                    }
                }

                hashes = newHashes;
            }

            // Final remaining hash = Merkle Root
            return hashes[0];
        }

        public void AddRewardTransaction(string minerAddress)
        {
            this.minerAddress = minerAddress;

            fees = 0;

            // Calculate total transaction fees
            foreach (Transaction transaction in transactions)
            {
                fees += transaction.fee;
            }

            // Create mining reward transaction
            Transaction rewardTransaction = new Transaction(
                "Mine Rewards",
                minerAddress,
                reward + fees,
                0,
                ""
            );

            // Add reward transaction into the block
            transactions.Add(rewardTransaction);
        }

        // Returns block details as readable text
        public string PrintBlock()
        {
            string output =
                "Block Index: " + index +
                "\nTimestamp: " + timestamp +
                "\nHash: " + hash +
                "\nPrevious Hash: " + prevHash +
                "\nMerkle Root: " + merkleRoot +
                "\nNonce: " + nonce +
                "\nDifficulty: " + difficulty +
                "\nMining Time: " + miningTimeSeconds + " seconds" +
                "\nTransactions: " + transactions.Count;

            foreach (Transaction t in transactions)
            {
                output += "\n\n" + t.PrintTransaction();
            }

            return output;
        }
    }
}