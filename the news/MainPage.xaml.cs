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



namespace the_news
{
    
    
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var applicationView = ApplicationView.GetForCurrentView();

            
            applicationView.SetPreferredMinSize(new Size(815, 471));

            
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
                    Text = "Someone just died! Who? We don't know."
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

            
            var toastNotif = new ToastNotification(toastContent.GetXml());

            
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
                    Text = "BREAKING NEWS! the earth is on fire lmfao"
                },
                new AdaptiveGroup()
                {
                    Children =
                    {
                        new AdaptiveSubgroup()
                        {
                            HintWeight = 1,
                            Children =
                            {
                                new AdaptiveText()
                                {
                                    Text = "Mon",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveImage()
                                {
                                    HintRemoveMargin = true,
                                    Source = "Assets/Images/Sunny.png"
                                },
                                new AdaptiveText()
                                {
                                    Text = "63°",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveText()
                                {
                                    Text = "42°",
                                    HintStyle = AdaptiveTextStyle.CaptionSubtle,
                                    HintAlign = AdaptiveTextAlign.Center
                                }
                            }
                        },
                        new AdaptiveSubgroup()
                        {
                            HintWeight = 1,
                            Children =
                            {
                                new AdaptiveText()
                                {
                                    Text = "Tue",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveImage()
                                {
                                    HintRemoveMargin = true,
                                    Source = "Assets/Images/Sunny.png"
                                },
                                new AdaptiveText()
                                {
                                    Text = "78°",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveText()
                                {
                                    Text = "60°",
                                    HintStyle = AdaptiveTextStyle.CaptionSubtle,
                                    HintAlign = AdaptiveTextAlign.Center
                                }
                            }
                        },
                        new AdaptiveSubgroup()
                        {
                            HintWeight = 1,
                            Children =
                            {
                                new AdaptiveText()
                                {
                                    Text = "Wed",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveImage()
                                {
                                    HintRemoveMargin = true,
                                    Source = "Assets/Images/Sunny.png"
                                },
                                new AdaptiveText()
                                {
                                    Text = "96°",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveText()
                                {
                                    Text = "76°",
                                    HintStyle = AdaptiveTextStyle.CaptionSubtle,
                                    HintAlign = AdaptiveTextAlign.Center
                                }
                            }
                        },
                        new AdaptiveSubgroup()
                        {
                            HintWeight = 1,
                            Children =
                            {
                                new AdaptiveText()
                                {
                                    Text = "Thu",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveImage()
                                {
                                    HintRemoveMargin = true,
                                    Source = "Assets/Images/Sunny.png"
                                },
                                new AdaptiveText()
                                {
                                    Text = "132°",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveText()
                                {
                                    Text = "89°",
                                    HintStyle = AdaptiveTextStyle.CaptionSubtle,
                                    HintAlign = AdaptiveTextAlign.Center
                                }
                            }
                        },
                        new AdaptiveSubgroup()
                        {
                            HintWeight = 1,
                            Children =
                            {
                                new AdaptiveText()
                                {
                                    Text = "Fri",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveImage()
                                {
                                    HintRemoveMargin = true,
                                    Source = "Assets/Images/Sunny.png"
                                },
                                new AdaptiveText()
                                {
                                    Text = "244°",
                                    HintAlign = AdaptiveTextAlign.Center
                                },
                                new AdaptiveText()
                                {
                                    Text = "120°",
                                    HintStyle = AdaptiveTextStyle.CaptionSubtle,
                                    HintAlign = AdaptiveTextAlign.Center
                                }
                            }
                        }
                    }
                }
            }
                    }
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
                    Text = "John Phone sent you a friend request"
                },
                new AdaptiveText()
                {
                    Text = "i want Sponsorships."
                }
            },
                        AppLogoOverride = new ToastGenericAppLogo()
                        {
                            Source = "Assets/Images/johnphone.jpg",
                            HintCrop = ToastGenericAppLogoCrop.Circle
                        }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("Accept", "action=acceptFriendRequest&userId=49183")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButton("Decline", "action=declineFriendRequest&userId=49183")
            {
                ActivationType = ToastActivationType.Background
            }
        }
                },
                Launch = "action=viewFriendRequest&userId=49183"
            };

            
            var toastNotif = new ToastNotification(toastContent.GetXml());

            
            ToastNotificationManager.CreateToastNotifier().Show(toastNotif);
        }


        
        private DispatcherTimer toastTimer;
        private int currentToastIndex = 0;
        private bool isAutoToastRunning = false;


        
        private double GetIntervalFromUI()
        {
            
            return IntervalSlider.Value; 
        }

        
        private void IntervalSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            
            if (toastTimer != null && isAutoToastRunning)
            {
                toastTimer.Stop();
                toastTimer.Interval = TimeSpan.FromMilliseconds(e.NewValue);
                toastTimer.Start();
            }

            
            if (IntervalLabel != null)
            {
                IntervalLabel.Text = $"Interval: {e.NewValue:F0}ms";
            }
        }


        private void AutoToast_Click(object sender, RoutedEventArgs e)
        {
            if (!isAutoToastRunning)
            {
                
                isAutoToastRunning = true;
                currentToastIndex = 0;

                double intervalMs = GetIntervalFromUI();


                if (toastTimer == null)
                {
                    toastTimer = new DispatcherTimer();
                    toastTimer.Interval = TimeSpan.FromMilliseconds(intervalMs);
                    toastTimer.Tick += ToastTimer_Tick;
                }

                toastTimer.Start();

                
                if (sender is Button btn)
                {
                    btn.Content = "Stop Auto Toast";
                }
            }
            else
            {
                
                isAutoToastRunning = false;
                toastTimer?.Stop();

                
                if (sender is Button btn)
                {
                    btn.Content = "Start Auto Toast";
                }
            }
        }

        private void ToastTimer_Tick(object sender, object e)
        {
            
            switch (currentToastIndex)
            {
                case 0:
                    Button_Click(null, null); 
                    break;
                case 1:
                    Button_Click_1(null, null); 
                    break;
                case 2:
                    Button_Click_2(null, null); 
                    break;
                case 3:
                    Button_Click_3(null, null); 
                    break;
                case 4:
                    Button_Click_4(null, null); 
                    break;
                case 5:
                    Button_Click_5(null, null); 
                    break;
                case 6:
                    Button_Click_6(null, null);
                    break;
                case 7:
                    Button_Click_7(null, null);
                    break;
            }

            
            currentToastIndex = (currentToastIndex + 1) % 8;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
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
                    Text = "we redesigned our website"
                },
                new AdaptiveText()
                {
                    Text = "enjoy it and leave feed back"
                },
                new AdaptiveImage()
                {
                    Source = "Assets/Images/redesign.png"
                }
            }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
        {
            new ToastButton("good", "likePhoto&photoId=92187")
            {
                ActivationType = ToastActivationType.Background
            },
            new ToastButton("horrid", "action=commentPhoto&photoId=92187")
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

        private void Button_Click_8(object sender, RoutedEventArgs e)
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
                    Text = "California man posts TikTok of him riding in his golf cart rambling on about 'roadblocks' on the beach, goes crazy fucking viral."
                },
                new AdaptiveImage()
                {
                    Source = "Assets/Images/roadblocks.gif"
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
    }
}
