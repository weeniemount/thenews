using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.StartScreen;
using Windows.UI.ViewManagement;
using Windows.Data.Xml.Dom;
using Windows.Storage;                 // For ApplicationData
using Windows.UI.StartScreen;          // For SecondaryTile and TileSize
using Windows.UI.Notifications;        // For TileUpdateManager etc.
using Windows.Data.Xml.Dom;            // For XmlDocument
using Windows.ApplicationModel.Background;  // For background task registration



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace the_news
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            this.InitializeComponent();
            var applicationView = ApplicationView.GetForCurrentView();


            applicationView.SetPreferredMinSize(new Size(815, 471));


            bool viewShown = applicationView.TryResizeView(new Size(815, 471));
        }

        private void Button_Click_1_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
            {
                new AdaptiveText()
                {
                    Text = "BREAKING NEWS!!!!!!!!!!!!!!!!!!!!!!"
                },
                new AdaptiveText()
                {
                    Text = "MAZE CONCENTRATED ON GAMBLING SO HARD THEY GOT $-1 IN RETURN???"
                },
                new AdaptiveImage()
                {
                    Source = "Assets/Images/maze.png"
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("Read More", "likePhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButton("discard", "action=commentPhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Foreground
            }
        }
                },
                Launch = "action=viewPhoto&photoId=92187"
            };

            var toastNotif = new ToastNotification(toastContent.GetXml());
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
            {
                new AdaptiveText()
                {
                    Text = "BREAKING NEWS!!!"
                },
                new AdaptiveText()
                {
                    Text = "femboyLabs has rebranded again!"
                },
                new AdaptiveImage()
                {
                    Source = "Assets/Images/astolfo.jpg"
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("Read More", "likePhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButton("discard", "action=commentPhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Foreground
            }
        }
                },
                Launch = "action=viewPhoto&photoId=92187"
            };

            var toastNotif = new ToastNotification(toastContent.GetXml());
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
            {
                new AdaptiveText()
                {
                    Text = "BREAKING NEWS!!!"
                },
                new AdaptiveText()
                {
                    Text = "Bussin Industries shares cryptic note on staff channels."
                },
                new AdaptiveText()
                    {
                        Text = "\nSource: X",
                        HintStyle = AdaptiveTextStyle.Header
                    },
                new AdaptiveImage()
                {
                    Source = "Assets/Images/bussin_industries.png"
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("Read More", "likePhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButton("discard", "action=commentPhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Foreground
            }
        }
                },
                Launch = "action=viewPhoto&photoId=92187"
            };

            var toastNotif = new ToastNotification(toastContent.GetXml());
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
            {
                new AdaptiveText()
                {
                    Text = "BREAKING NEWS!!!"
                },
                new AdaptiveText()
                {
                    Text = "the h is here"
                },
                new AdaptiveImage()
                {
                    Source = "Assets/Images/h.gif"
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("Read More", "likePhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButton("discard", "action=commentPhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Foreground
            }
        }
                },
                Launch = "action=viewPhoto&photoId=92187"
            };

            var toastNotif = new ToastNotification(toastContent.GetXml());
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }

        private async void Spawnhtile_Click(object sender, RoutedEventArgs e)
        {
            var tileId = "h" + Guid.NewGuid().ToString(); // Unique ID per tile

            var secondaryTile = new SecondaryTile(
                tileId,
                "h",
                "action=h",
                new Uri("ms-appx:///Assets/Images/h/h_1.png"), // first frame icon
                Windows.UI.StartScreen.TileSize.Square150x150);

            secondaryTile.VisualElements.BackgroundColor = Windows.UI.Colors.Orange;

            bool isPinned = await secondaryTile.RequestCreateAsync();

            if (isPinned)
            {
                // Store tileId so background task can find it
                ApplicationData.Current.LocalSettings.Values["AnimatedTileId"] = tileId;

                UpdateSecondaryTileAnimation(tileId);
                await RegisterhTileUpdateBackgroundTaskAsync();
            }
        }

        private void UpdateSecondaryTileAnimation(string tileId)
        {
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

                var xmlDoc = new Windows.Data.Xml.Dom.XmlDocument();
                xmlDoc.LoadXml(tileXmlString);

                var tileNotification = new TileNotification(xmlDoc);
                tileNotification.ExpirationTime = DateTimeOffset.Now.AddSeconds(i * 2);

                tileUpdater.Update(tileNotification);
            }
        }

        private async System.Threading.Tasks.Task RegisterhTileUpdateBackgroundTaskAsync()
        {
            const string taskName = "hTileUpdateBackgroundTask";

            foreach (var task in BackgroundTaskRegistration.AllTasks)
            {
                if (task.Value.Name == taskName)
                    return; // Already registered
            }

            var builder = new BackgroundTaskBuilder
            {
                Name = taskName,
                TaskEntryPoint = "the_news.hTileUpdateBackgroundTask"
            };

            // Runs every 15 minutes (minimum allowed interval)
            builder.SetTrigger(new TimeTrigger(15, false));

            var access = await BackgroundExecutionManager.RequestAccessAsync();

            if (access == BackgroundAccessStatus.AlwaysAllowed || access == BackgroundAccessStatus.AllowedSubjectToSystemPolicy)
            {
                builder.Register();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
            {
                new AdaptiveText()
                {
                    Text = "⚾️ Baseball on Discord?! 🤯"
                },
                new AdaptiveText()
                {
                    Text = "Fr fr, a baseball emoji just dropped on Discord. Icl, ts kinda mogging ngl. 🤣"
                },
                new AdaptiveImage()
                {
                    Source = "Assets/Images/whateverthisis.png"
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("Read More", "likePhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButton("discard", "action=commentPhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Foreground
            }
        }
                },
                Launch = "action=viewPhoto&photoId=92187"
            };

            var toastNotif = new ToastNotification(toastContent.GetXml());
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
            {
                new AdaptiveText()
                {
                    Text = "John Pork"
                },
                new AdaptiveText()
                {
                    Text = "Incoming Call - Sattelite"
                },
                new AdaptiveImage()
                {
                    HintCrop = AdaptiveImageCrop.Circle,
                    Source = "Assets/Images/johnpork.jpg"
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("Answer", "action=answer&callId=938163")
            {
                ActivationType = ToastActivationType.Foreground,
                ImageUri = "Assets/Images/answer.png"
            }
        }
                },
                Launch = "action=answer&callId=938163",
                Scenario = ToastScenario.IncomingCall,

                Audio = new ToastAudio()
                {
                    Src = new Uri("ms-appx:///Assets/hescalling.wav"),
                    Loop = true
                }
            };


            var toastNotif = new ToastNotification(toastContent.GetXml());


            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var toastContent = new ToastContent()
            {
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
            {
                new AdaptiveText()
                {
                    Text = "Text message from +1 248-434-5508"
                },
                new AdaptiveText()
                {
                    Text = "We've successfully assassinated the attacker. Thank you for contacting Valve Support."
                }
            },
                        Attribution = new ToastGenericAttributionText()
                        {
                            Text = "Linker's Samsung Galaxy"
                        }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("Gamble it all away", "action=pauseDownload&downloadId=9438108")
            {
                ActivationType = ToastActivationType.Background
            }
        }
                },
                Launch = "action=viewStory&storyId=92187"
            };

            // Create the toast notification
            var toastNotif = new ToastNotification(toastContent.GetXml());

            // And send the notification
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }
    }
}
