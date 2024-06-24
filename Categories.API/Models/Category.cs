using Categories.API.Models.Primitives;
using System.Collections.ObjectModel;

namespace Categories.API.Models;

public class Category : Entity
{

    private readonly Collection<Category> _subCategories = [];

    public string Name { get; private set; }

    public string Description { get; private set; }

    public Guid? ParentCategoryId { get; private set; }

    public IReadOnlyCollection<Category> SubCategories => _subCategories;


    public static Category Create(
        Guid id,
        string name,
        string description,
        Category? Parent = null,
        Collection<Category>? subCategories = null)
    {
        // validation
        return new Category(id, name, description, Parent, subCategories ?? []);
    }


    private Category(Guid id) : base(id)
    {
    }

    private Category(Guid id, string name, string description, Category? parent, Collection<Category> categories) : base(id)
    {
        Name = name;
        Description = description;
        ParentCategoryId = parent?.Id;
        _subCategories = categories;
    }

    private Category() : base(Guid.NewGuid())
    {
    }
}
