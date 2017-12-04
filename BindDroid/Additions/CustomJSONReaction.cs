
namespace IT.Near.Sdk.Reactions.Customjsonplugin
{
    public partial class CustomJSONReaction 
    {
		protected override void NormalizeElement(global::Java.Lang.Object element)
		{
			NormalizeElement(element as IT.Near.Sdk.Reactions.Customjsonplugin.Model.CustomJSON);
		}
		protected override void InjectRecipeId(global::Java.Lang.Object element, string recipeId)
		{
			InjectRecipeId(element as IT.Near.Sdk.Reactions.Customjsonplugin.Model.CustomJSON, recipeId);
		}
    }
}