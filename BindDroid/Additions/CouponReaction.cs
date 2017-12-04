namespace IT.Near.Sdk.Reactions.Couponplugin
{
    public partial class CouponReaction 
    {
		protected override void NormalizeElement(global::Java.Lang.Object element)
		{
            NormalizeElement(element as IT.Near.Sdk.Reactions.Couponplugin.Model.Coupon);
		}
		protected override void InjectRecipeId(global::Java.Lang.Object element, string recipeId)
		{
			InjectRecipeId(element as IT.Near.Sdk.Reactions.Couponplugin.Model.Coupon, recipeId);
		}
    }
}