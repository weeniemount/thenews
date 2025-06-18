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
    }
}
