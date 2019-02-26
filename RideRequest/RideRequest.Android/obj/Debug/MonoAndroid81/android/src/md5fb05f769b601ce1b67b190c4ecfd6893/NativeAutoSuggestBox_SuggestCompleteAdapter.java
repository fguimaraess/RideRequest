package md5fb05f769b601ce1b67b190c4ecfd6893;


public class NativeAutoSuggestBox_SuggestCompleteAdapter
	extends android.widget.ArrayAdapter
	implements
		mono.android.IGCUserPeer,
		android.widget.Filterable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getFilter:()Landroid/widget/Filter;:GetGetFilterHandler\n" +
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"";
		mono.android.Runtime.register ("dotMorten.Xamarin.Forms.NativeAutoSuggestBox+SuggestCompleteAdapter, dotMorten.Xamarin.Forms.AutoSuggestBox", NativeAutoSuggestBox_SuggestCompleteAdapter.class, __md_methods);
	}


	public NativeAutoSuggestBox_SuggestCompleteAdapter (android.content.Context p0, int p1)
	{
		super (p0, p1);
		if (getClass () == NativeAutoSuggestBox_SuggestCompleteAdapter.class)
			mono.android.TypeManager.Activate ("dotMorten.Xamarin.Forms.NativeAutoSuggestBox+SuggestCompleteAdapter, dotMorten.Xamarin.Forms.AutoSuggestBox", "Android.Content.Context, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}


	public NativeAutoSuggestBox_SuggestCompleteAdapter (android.content.Context p0, int p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == NativeAutoSuggestBox_SuggestCompleteAdapter.class)
			mono.android.TypeManager.Activate ("dotMorten.Xamarin.Forms.NativeAutoSuggestBox+SuggestCompleteAdapter, dotMorten.Xamarin.Forms.AutoSuggestBox", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public NativeAutoSuggestBox_SuggestCompleteAdapter (android.content.Context p0, int p1, int p2, java.util.List p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == NativeAutoSuggestBox_SuggestCompleteAdapter.class)
			mono.android.TypeManager.Activate ("dotMorten.Xamarin.Forms.NativeAutoSuggestBox+SuggestCompleteAdapter, dotMorten.Xamarin.Forms.AutoSuggestBox", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib:System.Collections.IList, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public NativeAutoSuggestBox_SuggestCompleteAdapter (android.content.Context p0, int p1, int p2, java.lang.Object[] p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == NativeAutoSuggestBox_SuggestCompleteAdapter.class)
			mono.android.TypeManager.Activate ("dotMorten.Xamarin.Forms.NativeAutoSuggestBox+SuggestCompleteAdapter, dotMorten.Xamarin.Forms.AutoSuggestBox", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib:Java.Lang.Object[], Mono.Android", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public NativeAutoSuggestBox_SuggestCompleteAdapter (android.content.Context p0, int p1, java.util.List p2)
	{
		super (p0, p1, p2);
		if (getClass () == NativeAutoSuggestBox_SuggestCompleteAdapter.class)
			mono.android.TypeManager.Activate ("dotMorten.Xamarin.Forms.NativeAutoSuggestBox+SuggestCompleteAdapter, dotMorten.Xamarin.Forms.AutoSuggestBox", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Collections.IList, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public NativeAutoSuggestBox_SuggestCompleteAdapter (android.content.Context p0, int p1, java.lang.Object[] p2)
	{
		super (p0, p1, p2);
		if (getClass () == NativeAutoSuggestBox_SuggestCompleteAdapter.class)
			mono.android.TypeManager.Activate ("dotMorten.Xamarin.Forms.NativeAutoSuggestBox+SuggestCompleteAdapter, dotMorten.Xamarin.Forms.AutoSuggestBox", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:Java.Lang.Object[], Mono.Android", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public android.widget.Filter getFilter ()
	{
		return n_getFilter ();
	}

	private native android.widget.Filter n_getFilter ();


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
