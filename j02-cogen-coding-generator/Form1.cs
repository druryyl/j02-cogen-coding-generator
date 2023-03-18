using System.Text;

namespace j02_cogen_coding_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private EntityModel CreateEntity()
        {
            var result = new EntityModel
            {
                Name = ModelNameTextBox.Text,
                PrefixTable = PrefixTableTextBox.Text,
                ListProperties = new()
            };

            var listProperty = PropertiesTextBox.Text.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None);
            foreach (var item in listProperty)
                result.ListProperties.Add(new PropertyModel(item));

            return result;
        }

        private static string GenClassModel(EntityModel entity)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {entity.Name}Model");
            sb.AppendLine("{");
            foreach (var item in entity.ListProperties)
                sb.AppendLine($"\tpublic string {item.Name} {{get; set;}}");
            sb.AppendLine("}");

            return sb.ToString();
        }

        private static string GenQueryDal(EntityModel entity)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"public class {entity.Name}Dal : I{entity.Name}Dal");
            sb.AppendLine($"\tprivate readonly DatabaseOptions _opt;");
            sb.AppendLine($"\tpublic {entity.Name}Dal(IOptions<DatabaseOptions> opt)");
            sb.AppendLine($"\t{{");
            sb.AppendLine($"\t\t_opt = opt.Value;");
            sb.AppendLine($"\t}}");

            sb.AppendLine($"\tpublic void Insert({entity.Name}Model model");
            sb.AppendLine($"\t{{");
            sb.AppendLine($"\t\tconst string sql = \"");
            sb.AppendLine($"\t\t\tINSERT INTO {entity.PrefixTable}_{entity.Name} (");
            foreach(var item in entity.ListProperties)
                sb.AppendLine($"\t\t\t\t{item.Name},");

            sb.AppendLine($"\t}}");

            return sb.ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var entity = CreateEntity();
            ClassModelTextBox.Text = GenClassModel(entity);
            QueryDalTextBox.Text = GenQueryDal(entity);
        }
    }
}