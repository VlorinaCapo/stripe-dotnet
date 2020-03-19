namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class SourceService : Service<Source>,
        ICreatable<Source, SourceCreateOptions>,
        IRetrievable<Source, SourceGetOptions>,
        IUpdatable<Source, SourceUpdateOptions>,
        INestedListable<Source, SourceListOptions>
    {
        public SourceService()
            : base(null)
        {
        }

        public SourceService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/sources";

        public virtual Source Attach(string parentId, SourceAttachOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<Source> AttachAsync(string parentId, SourceAttachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<Source> AttachAsync(string parentId, SourceAttachOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.RequestAsync<Source>(HttpMethod.Post, $"/v1/customers/{parentId}/sources", options, requestOptions, cancellationToken);
        }

        public virtual Source Create(SourceCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Source> CreateAsync(SourceCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Source Detach(string parentId, string id, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{id}", null, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<Source> DetachAsync(string parentId, string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<Source> DetachAsync(string parentId, string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.RequestAsync<Source>(HttpMethod.Delete, $"/v1/customers/{parentId}/sources/{id}", null, requestOptions, cancellationToken);
        }

        public virtual Source Get(string id, SourceGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<Source> GetAsync(string id, SourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<Source> GetAsync(string id, SourceGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Source> List(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Source>>(HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<StripeList<Source>> ListAsync(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<StripeList<Source>> ListAsync(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.RequestAsync<StripeList<Source>>(HttpMethod.Get, $"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Source> ListAutoPaging(string parentId, SourceListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Source>($"/v1/customers/{parentId}/sources", options ?? new SourceListOptions(), requestOptions);
        }

        public virtual Source Update(string id, SourceUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<Source> UpdateAsync(string id, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<Source> UpdateAsync(string id, SourceUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual Source Verify(string id, SourceVerifyOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Source>(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify", options, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<Source> VerifyAsync(string id, SourceVerifyOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<Source> VerifyAsync(string id, SourceVerifyOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.RequestAsync<Source>(HttpMethod.Post, $"{this.InstanceUrl(id)}/verify", options, requestOptions, cancellationToken);
        }
    }
}
