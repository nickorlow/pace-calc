package crc6473f78886b71f8f16;


public class MainActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_OpenInputPage:(Landroid/view/View;)V:__export__\n" +
			"n_OpenWelcomePage:(Landroid/view/View;)V:__export__\n" +
			"n_OpenCalculationPage:(Landroid/view/View;)V:__export__\n" +
			"n_CalculateCustomPace:(Landroid/view/View;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("PaceCalc.MainActivity, PaceCalc", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("PaceCalc.MainActivity, PaceCalc", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void OpenInputPage (android.view.View p0)
	{
		n_OpenInputPage (p0);
	}

	private native void n_OpenInputPage (android.view.View p0);


	public void OpenWelcomePage (android.view.View p0)
	{
		n_OpenWelcomePage (p0);
	}

	private native void n_OpenWelcomePage (android.view.View p0);


	public void OpenCalculationPage (android.view.View p0)
	{
		n_OpenCalculationPage (p0);
	}

	private native void n_OpenCalculationPage (android.view.View p0);


	public void CalculateCustomPace (android.view.View p0)
	{
		n_CalculateCustomPace (p0);
	}

	private native void n_CalculateCustomPace (android.view.View p0);

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