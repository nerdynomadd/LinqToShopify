using LinqToShopify.GraphQL.Admin.Context.Global.Mutation.Error;

namespace LinqToShopify.GraphQL.Admin.Context.Global.Mutation.Result
{
	public interface IMutationResult<T> where T: IDisplayableError
	{
		
	}
}