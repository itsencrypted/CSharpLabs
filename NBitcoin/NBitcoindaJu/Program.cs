using NBitcoin;
using NBitcoin.Protocol;
using System;
using System.Threading;

namespace NBitcoindaJu
{
    class Program
    {
        static void Main(string[] args)
        {
            //BitcoinSecret = Pvtekey da MainNet (e nao da RegTest/TestNet)
            var secret = new BitcoinSecret("L33zJLakj63bHTrjUj1TkkzJTrXzY8LKsucbwqqPR8k7T3bVZde5");
            var key = secret.PrivateKey;
            Console.WriteLine(key.PubKey.GetAddress(Network.Main));
            //Console.WriteLine("Hello hello");

            Transaction tx = new Transaction();
            //an Input represents which coin do you want to spend
            var input = new TxIn();
            //Outpoint ===>>> 0 nao quero gastar, 1 = quero gastar esse Bitcoin
            input.PrevOut = new OutPoint(new uint256("22fb2586f83af6fa39494a3a11ffd02f86ed0388e6e16398eb43625bf1394dbb"), 1);
            input.ScriptSig = secret.GetAddress().ScriptPubKey;
            tx.AddInput(input);

            TxOut output = new TxOut();
            string address = "356sJ4Hcmqf2VWJRMmhaVpNQhFbb7AeD77";
            var destination = BitcoinAddress.Create(address, Network.Main);
            Money fee = Money.Satoshis(40000);
            output.Value = Money.Coins(0.1m) - fee;
            output.ScriptPubKey = destination.ScriptPubKey;
            tx.AddOutput(output); 

            tx.Sign(secret, false);

            var node = Node.Connect(Network.Main, "92.154.193.10:8333");
            node.VersionHandshake();
            node.SendMessage(new InvPayload(tx));
            node.SendMessage(new TxPayload(tx));
            Thread.Sleep(4000);
            node.Disconnect();
        }
    }
}
