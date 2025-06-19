using Windows.ApplicationModel.Background;
using Windows.Storage;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using System;

namespace the_news
{
    public sealed class TileUpdateBackgroundTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            var deferral = taskInstance.GetDeferral();

            // Read stored tileId from local settings
            var localSettings = ApplicationData.Current.LocalSettings;
            if (!localSettings.Values.ContainsKey("AnimatedTileId"))
            {
                deferral.Complete();
                return;
            }

            string tileId = localSettings.Values["AnimatedTileId"] as string;

            var tileUpdater = TileUpdateManager.CreateTileUpdaterForSecondaryTile(tileId);
            tileUpdater.EnableNotificationQueue(true);
            tileUpdater.Clear();

            for (int i = 1; i <= 14; i++)
            {
                var tileXmlString = $@"
                <tile>
                    <visual>
                        <binding template='TileSquare150x150Image'>
                            <image id='1' src='ms-appx:///Assets/Images/h/h_{i}.png' alt='h'/>
                        </binding>
                    </visual>
                </tile>";

                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(tileXmlString);

                var tileNotification = new TileNotification(xmlDoc);

                tileNotification.ExpirationTime = DateTimeOffset.Now.AddSeconds(i * 2);

                tileUpdater.Update(tileNotification);
            }

            deferral.Complete();
        }
    }
}
