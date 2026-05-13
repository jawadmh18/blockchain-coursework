using System;
using System.IO;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        // Create a blockchain variable
        Blockchain blockchain;

        public BlockchainApp()
        {
            InitializeComponent();

            // Initialise blockchain
            blockchain = new Blockchain();

            // Default mining preference
            MiningPreferenceComboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Print a block
        private void button1_Click(object sender, EventArgs e)
        {
            int blockIndex = int.Parse(textBox1.Text);
            richTextBox1.Text = blockchain.ReadBlock(blockIndex);
        }

        // Add a new block
        private void button2_Click(object sender, EventArgs e)
        {
            string preference = MiningPreferenceComboBox.SelectedItem.ToString();

            blockchain.AddBlock(PublicKeyTextBox.Text, preference);

            richTextBox1.Text =
                "New block mined using " + preference +
                " preference!" +
                "\nTotal blocks: " + blockchain.blocks.Count +
                "\nNext Difficulty: " + blockchain.currentDifficulty;
        }

        // Generate Wallet
        private void button3_Click(object sender, EventArgs e)
        {
            string privateKey;

            Wallet.Wallet newWallet = new Wallet.Wallet(out privateKey);

            PublicKeyTextBox.Text = newWallet.publicID;
            PrivateKeyTextBox.Text = privateKey;

            richTextBox1.Text = "Wallet generated.";
        }

        // Validate Keys
        private void button4_Click(object sender, EventArgs e)
        {
            bool valid = Wallet.Wallet.ValidatePrivateKey(
                PrivateKeyTextBox.Text,
                PublicKeyTextBox.Text
            );

            richTextBox1.Text = valid ? "Keys are valid" : "Keys are NOT valid";
        }

        // Create Transaction
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PublicKeyTextBox.Text) ||
                string.IsNullOrWhiteSpace(PrivateKeyTextBox.Text) ||
                string.IsNullOrWhiteSpace(ReceiverKeyTextBox.Text))
            {
                richTextBox1.Text = "Please generate a wallet and enter a receiver key.";
                return;
            }

            if (!double.TryParse(AmountTextBox.Text, out double amount))
            {
                richTextBox1.Text = "Please enter a valid amount, e.g. 10.";
                return;
            }

            if (!double.TryParse(FeeTextBox.Text, out double fee))
            {
                richTextBox1.Text = "Please enter a valid fee, e.g. 0.001.";
                return;
            }

            double senderBalance = blockchain.GetBalance(PublicKeyTextBox.Text);

            if (senderBalance < amount + fee)
            {
                richTextBox1.Text = "Transaction rejected: insufficient balance.";
                return;
            }

            string senderPublicKey = PublicKeyTextBox.Text;
            string senderPrivateKey = PrivateKeyTextBox.Text;
            string receiverPublicKey = ReceiverKeyTextBox.Text;

            Transaction transaction = new Transaction(
                senderPublicKey,
                receiverPublicKey,
                amount,
                fee,
                senderPrivateKey
            );

            blockchain.pendingTransactions.Add(transaction);

            richTextBox1.Text = transaction.PrintTransaction();
        }

        // Read all blocks
        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ReadAllBlocks();
        }

        // Read pending transactions
        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ReadPendingTransactions();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void PublicKeyTextBox_TextChanged(object sender, EventArgs e) { }
        private void PrivateKeyTextBox_TextChanged(object sender, EventArgs e) { }

        // Validate blockchain
        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ValidateChain();
        }

        // Check wallet balance
        private void button9_Click(object sender, EventArgs e)
        {
            double balance = blockchain.GetBalance(PublicKeyTextBox.Text);

            richTextBox1.Text = "Wallet Balance: " + balance + " AssignmentCoins";
        }

        // Tamper with block for testing validation
        private void button10_Click(object sender, EventArgs e)
        {
            blockchain.blocks[1].transactions[0].amount = 9999;

            richTextBox1.Text = "Block transaction tampered with.";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filePath = "blockchain_export.txt";

            string blockchainData = blockchain.ReadAllBlocks();

            File.WriteAllText(filePath, blockchainData);

            richTextBox1.Text = "Blockchain exported successfully to: " + filePath;
        }
    }
}