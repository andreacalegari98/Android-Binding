namespace IT.Near.Sdk.Reactions.Feedbackplugin
{
    public partial class FeedbackReaction 
    {
		protected override void NormalizeElement(global::Java.Lang.Object element)
		{
            NormalizeElement(element as IT.Near.Sdk.Reactions.Feedbackplugin.Model.Feedback);
		}
		protected override void InjectRecipeId(global::Java.Lang.Object element, string recipeId)
		{
            InjectRecipeId(element as IT.Near.Sdk.Reactions.Feedbackplugin.Model.Feedback, recipeId);
		}
    }
}