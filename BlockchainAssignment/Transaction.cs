using System;
using System.Security.Cryptography;
using System.Text;

namespace BlockchainAssignment
{
    class Transaction
    {
        public string hash;
        public string signature;

        public string senderAddress;
        public string recipientAddress;

        public DateTime timestamp;
        public double amount;
        public double fee;

        // NOTE: We take the private key as a parameter, but we DO NOT store it as a field.
        public Transaction(string senderAddress, string recipientAddress, double amount, double fee, string senderPrivateKey)
        {
            this.senderAddress = senderAddress;
            this.recipientAddress = recipientAddress;
            this.amount = amount;
            this.fee = fee;

            timestamp = DateTime.Now;

            // 1) Create a hash of the transaction contents
            hash = CreateHash();

            // 2) Sign the hash with the sender's private key (digital signature)
            signature = Wallet.Wallet.CreateSignature(senderAddress, senderPrivateKey, hash);
        }

        // SHA-256 hash of transaction contents
        public string CreateHash()
        {
            SHA256 hasher = SHA256Managed.Create();

            string input =
                senderAddress +
                recipientAddress +
                amount.ToString() +
                fee.ToString() +
                timestamp.ToString();

            byte[] hashBytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            string result = string.Empty;
            foreach (byte b in hashBytes)
                result += string.Format("{0:x2}", b);

            return result;
        }

        public string PrintTransaction()
        {
            return "Transaction Hash: " + hash +
                   "\nDigital Signature: " + signature +
                   "\nTimestamp: " + timestamp +
                   "\nAmount: " + amount +
                   "\nFee: " + fee +
                   "\nSender Address: " + senderAddress +
                   "\nReceiver Address: " + recipientAddress;
        }
    }
}