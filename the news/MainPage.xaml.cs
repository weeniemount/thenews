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
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace the_news
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var applicationView = ApplicationView.GetForCurrentView();

            // Set preferred window size
            applicationView.SetPreferredMinSize(new Size(815, 471));

            // Try to resize the window
            bool viewShown = applicationView.TryResizeView(new Size(815, 471));
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
                    Text = "BREAKING FUCKING NEWS!!!!!!!!!!!!"
                },
                new AdaptiveText()
                {
                    Text = "Someone just died? Who? We don't know."
                }
            },
                        Attribution = new ToastGenericAttributionText()
                        {
                            Text = "The puter"
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
                    Text = "we need your money"
                },
                new AdaptiveText()
                {
                    Text = "donate to \"the news\""
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Inputs =
        {
            new ToastSelectionBox("status")
            {
                DefaultSelectionBoxItemId = "yes",
                Items =
                {
                    new ToastSelectionBoxItem("yes", "100k dollars"),
                    new ToastSelectionBoxItem("maybe", "1k dollars"),
                    new ToastSelectionBoxItem("no", "1 dollar")
                }
            }
        },
                    Buttons =
        {
            new ToastButton("gladly", "action=rsvpEvent&eventId=63851")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButtonDismiss("no please")
        }
                },
                Launch = "action=viewEvent&eventId=63851"
            };

            // Create the toast notification
            var toastNotif = new ToastNotification(toastContent.GetXml());

            // And send the notification
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
                    Text = "please donate us money"
                },
                new AdaptiveText()
                {
                    Text = "our in house servers ae dying of money :("
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Inputs =
        {
            new ToastSelectionBox("answer")
            {
                DefaultSelectionBoxItemId = "wrongDefault",
                Items =
                {
                    new ToastSelectionBoxItem("wrongDefault", "100k dollars"),
                    new ToastSelectionBoxItem("wrong", "1k dollars"),
                    new ToastSelectionBoxItem("wrong", "1 dollar")
                }
            }
        },
                    Buttons =
        {
            new ToastButtonSnooze("gladly"),
            new ToastButton("never disturb me again", "dismiss")
            {
                ActivationType = ToastActivationType.Background
            }
        }
                },
                Launch = "action=viewAlarm&alarmId=1",
                Scenario = ToastScenario.Alarm
            };

            // Create the toast notification
            var toastNotif = new ToastNotification(toastContent.GetXml());

            // And send the notification
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
                    Text = "welp"
                },
                new AdaptiveProgressBar()
                {
                    Value = AdaptiveProgressBarValue.FromBinding("0.02"),
                    ValueStringOverride = "21/15,245 files",
                    Title = "since you didn't donate to the news...",
                    Status = "deleting system32..."
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("cope ¯\\_(ツ)_/¯", "action=pauseDownload&downloadId=9438108")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButton("donate before its late", "action=cancelDownload&downloadId=9438108")
            {
                ActivationType = ToastActivationType.Background
            }
        }
                },
                Launch = "action=viewDownload&downloadId=9438108"
            };

            // Create the toast notification
            var toastNotif = new ToastNotification(toastContent.GetXml());

            // And send the notification
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
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
                    Text = "John Phone"
                },
                new AdaptiveText()
                {
                    Text = "Incoming Call - Sattelite"
                },
                new AdaptiveImage()
                {
                    HintCrop = AdaptiveImageCrop.Circle,
                    Source = "Assets/Images/johnphone.jpg"
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
                Scenario = ToastScenario.IncomingCall
            };

            // Create the toast notification
            var toastNotif = new ToastNotification(toastContent.GetXml());

            // And send the notification
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }
    }
}
