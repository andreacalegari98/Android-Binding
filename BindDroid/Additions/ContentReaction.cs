namespace IT.Near.Sdk.Reactions.Contentplugin
{

    // Metadata.xml XPath class reference: path="/api/package[@name='it.near.sdk.reactions.contentplugin']/class[@name='ContentReaction']"
   
    public partial class ContentReaction 
    {
        protected override void NormalizeElement(global::Java.Lang.Object element)
        {
			NormalizeElement(element as IT.Near.Sdk.Reactions.Contentplugin.Model.Content);
        }
        protected override void InjectRecipeId(global::Java.Lang.Object element, string recipeId)
        {
            InjectRecipeId(element as IT.Near.Sdk.Reactions.Contentplugin.Model.Content, recipeId);
        }
    }
}