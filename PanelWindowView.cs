namespace TinyPanel
{
    using Terminal.Gui;

    public partial class MyView : Window
    {

        private Label uptimeLabel;
        private TextField banIdField;
        private Button banButton;
        private TextField notifyField;
        private Button notifyButton;
        private Label chatsListLabel;
        private ListView chatsList;
        private Label logLabel;
        private ListView logList;
        private Button startOrStopButton;
        private Button restartButton;
        private Button updateCodeButton;
        private Button resetCacheButton;

        private FrameView chatsFrame;
        private FrameView logFrame;

        private void InitializeComponent()
        {
            Width = Dim.Fill(0);
            Height = Dim.Fill(0);
            X = 0;
            Y = 0;
            Modal = false;
            Text = "";
            Border.BorderStyle = BorderStyle.Single;
            Border.Effect3D = false;
            Border.DrawMarginFrame = true;
            TextAlignment = TextAlignment.Left;
            Title = "TinyPanel NURE bot";

            uptimeLabel = new Label()
            {
                Width = 10,
                Height = 1,
                X = 1,
                Y = Pos.Top(this),
                Data = "fetchLabel",
                Text = "Uptime: 12:32:27",
                TextAlignment = TextAlignment.Left
            };

            banIdField = new TextField()
            {
                Width = 20,
                Height = 1,
                X = 1,
                Y = Pos.Top(this) + 1,
                Data = "banId",
                Text = "Введіть ID",
                TextAlignment = TextAlignment.Left
            };

            banButton = new Button()
            {
                Width = 12,
                X = 23,
                Y = Pos.Top(this) + 1,
                Data = "banButton",
                Text = "Бан",
                TextAlignment = TextAlignment.Centered
            };

            notifyField = new TextField()
            {
                Width = 20,
                Height = 1,
                X = 1,
                Y = Pos.Top(this) + 3,
                Data = "notify",
                Text = "Введіть повідомлення",
                TextAlignment = TextAlignment.Left
            };

            notifyButton = new Button()
            {
                Width = 12,
                X = 23,
                Y = Pos.Top(this) + 3,
                Data = "notifyButton",
                Text = "Відправити",
                TextAlignment = TextAlignment.Centered
            };

            chatsListLabel = new Label()
            {
                Width = 10,
                Height = 1,
                X = 1,
                Y = Pos.Top(this) + 5,
                Data = "chatsLabel",
                Text = "Список чатів:",
                TextAlignment = TextAlignment.Left
            };

            chatsFrame = new FrameView()
            {
                Width = 50,
                Height = 15,
                X = 0,
                Y = 6,
                Data = "chatsFrame",
                TextAlignment = TextAlignment.Left
            };

            logLabel = new Label()
            {
                Width = 10,
                Height = 1,
                X = 52,
                Y = 0,
                Data = "logLabel",
                Text = "Журнал:",
                TextAlignment = TextAlignment.Left
            };

            logFrame = new FrameView()
            {
                Width = 50,
                Height = 20,
                X = 51,
                Y = 1,
                Data = "logFrame",
                TextAlignment = TextAlignment.Left
            };

            startOrStopButton = new Button()
            {
                Width = 12,
                X = Pos.Left(this),
                Y = Pos.Bottom(this) - 3,
                Data = "startOrStopButton",
                Text = "Ввімкнути",
                TextAlignment = TextAlignment.Centered,
                IsDefault = false
            };

            restartButton = new Button()
            {
                Width = 12,
                X = Pos.Left(this) + 15,
                Y = Pos.Bottom(this) - 3,
                Data = "restartButton",
                Text = "Перезавантажити",
                TextAlignment = TextAlignment.Centered,
                IsDefault = false
            };

            updateCodeButton = new Button()
            {
                Width = 12,
                X = Pos.Left(this) + 36,
                Y = Pos.Bottom(this) - 3,
                Data = "updateCodeButton",
                Text = "Оновити код",
                TextAlignment = TextAlignment.Centered,
                IsDefault = false
            };

            resetCacheButton = new Button()
            {
                Width = 12,
                X = Pos.Left(this) + 53,
                Y = Pos.Bottom(this) - 3,
                Data = "resetCacheButton",
                Text = "Скинути кеш",
                TextAlignment = TextAlignment.Centered,
                IsDefault = false
            };

            Add(uptimeLabel);

            Add(banIdField);
            Add(banButton);

            Add(notifyField);
            Add(notifyButton);

            Add(chatsListLabel);
            Add(chatsFrame);

            Add(logLabel);
            Add(logFrame);

            Add(startOrStopButton);
            Add(restartButton);
            Add(updateCodeButton);
            Add(resetCacheButton);
        }
    }
}
