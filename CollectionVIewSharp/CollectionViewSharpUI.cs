using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;

namespace CollectionVIewSharp;

public class CollectionViewSharpUI : ContentPage
{
    public class MyModel
    {

        public string Name { get; set; }
        public string Location { get; set; }

    }
    public CollectionViewSharpUI()
    {
        //Test1
        //var collectionView = new CollectionView
        //{
        //    ItemsSource = MyList,
        //};
        //Content = collectionView;



        //Test2
        List<MyModel> uList = new List<MyModel>()
        {
             new MyModel{ Name = "Xamarin Guy",Location = "Kathmandu,Nepal"},
             new MyModel{ Name = "MAUI",Location = "TX,USA",}

        };
        var collectionView = new CollectionView
        {
            ItemsSource = uList,
            ItemsLayout = new GridItemsLayout(orientation:ItemsLayoutOrientation.Vertical, span:2),

            ItemTemplate = new DataTemplate(() =>
                {
                    VerticalStackLayout VerticalView = new VerticalStackLayout {Spacing =2}.BackgroundColor(Colors.LightGray);
                    Label nameLabel = new Label { }.Center().TextColor(Colors.Black);
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    Label locationLabel = new Label { }.Center().TextColor(Colors.Black);
                    locationLabel.SetBinding(Label.TextProperty, "Location");

                    VerticalView.Children.Add(nameLabel);
                    VerticalView.Children.Add(locationLabel);

                    return VerticalView;
                })
        };
        Content = collectionView;
    }

}

