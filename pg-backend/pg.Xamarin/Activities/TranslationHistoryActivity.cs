using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace pg.Xamarin.Activities
{
    [Activity(Label = "@string/translation_history")]
    public class TranslationHistoryActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var phoneNumbers = Intent.Extras.GetStringArrayList("phone_numbers") ?? new string[0];

            this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, phoneNumbers);
        }
    }
}