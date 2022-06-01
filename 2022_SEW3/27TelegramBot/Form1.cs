using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace _27TelegramBot
{
    public partial class Form1 : Form
    {
        private TelegramBotClient botClient = new TelegramBotClient("5403663546:AAHQW5brSmzzTaAeWWkKsWVLtXi6cmVUnVY");
        private CancellationTokenSource cts = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = Array.Empty<UpdateType>() // receive all update types
            };
            botClient.StartReceiving(
                updateHandler: HandleUpdateAsync,
                errorHandler: HandlePollingErrorAsync,
                receiverOptions: receiverOptions,
                cancellationToken: cts.Token
            );

            var me = await botClient.GetMeAsync();

            //Console.WriteLine($"Start listening for @{me.Username}");
            //this.txtMessage.Text = $"Start listening for @{me.Username}";
            //Console.ReadLine();
            
            // Send cancellation request to stop bot
            //cts.Cancel();
        }

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Only process Message updates: https://core.telegram.org/bots/api#message
            if (update.Type != UpdateType.Message)
                return;
            // Only process text messages
            if (update.Message!.Type != MessageType.Text)
                return;

            var chatId = update.Message.Chat.Id;
            var messageText = update.Message.Text;

            this.txtMessage.Invoke(new Action(() =>
            {
                this.txtMessage.Text += ($"Received a '{messageText}' message in chat {chatId}.");
            }));

            //this.txtMessage.Text = ($"Received a '{messageText}' message in chat {chatId}.");

            // Echo received message text
            Telegram.Bot.Types.Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: "You said:\n" + messageText,
                cancellationToken: cancellationToken);
        }

        Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            //this.txtMessage.Text = ErrorMessage;
            return Task.CompletedTask;
        }
        
    }
}
