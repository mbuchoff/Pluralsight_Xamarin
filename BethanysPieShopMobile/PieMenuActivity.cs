using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using BethanysPieShopMobile.Adapters;

namespace BethanysPieShopMobile
{
    [Activity(Label = "PieMenuActivity")]
    public class PieMenuActivity : Activity
    {
        private RecyclerView _pieRecyclerView;
        private RecyclerView.LayoutManager _pieLayoutManager;
        private PieAdapter _pieAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.pie_menu_tabs);
            _pieRecyclerView = FindViewById<RecyclerView>(Resource.Id.pieMenuRecyclerView);

            _pieLayoutManager = new LinearLayoutManager(this);
            _pieRecyclerView.SetLayoutManager(_pieLayoutManager);
            _pieAdapter = new PieAdapter();
            _pieAdapter.ItemClick += _pieAdapter_ItemClick;
            _pieRecyclerView.SetAdapter(_pieAdapter);
        }

        private void _pieAdapter_ItemClick(object sender, int e)
        {
            using (var intent = new Intent())
            {
                intent.SetClass(this, typeof(PieDetailActivity));
                intent.PutExtra("selectedPieId", e);
                StartActivity(intent);
            }
        }
    }
}