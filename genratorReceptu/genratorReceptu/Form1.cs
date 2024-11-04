namespace genratorReceptu
{
    public partial class Form1 : Form
    {
        private List<string[]> receptyZDatabaze;
        private List<string[]> ingredienceKReceptumZDB;

        public Form1()
        {
            InitializeComponent();
            loadCategories();
            addIngredients();
            lstRecipes.Visible = false;
            btnBack.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
        }

        private List<string> loadIngredientsFromDB()
        {
            //pro úèely PoC
            List<string> loadedFromDatabase = new List<string> { "Rajèe", "Cibule", "Èesnek", "Houby", "Tìsto" };
            return loadedFromDatabase;
        }

        private void addIngredients()
        {
            List<string> ingrediences = loadIngredientsFromDB();
            for (int i = 0; i < ingrediences.Count; i++)
            {
                clbIngredient.Items.Add(ingrediences[i]);
            }
        }

        private List<string> usersIngrediences()
        {
            List<string> ingrediences = new List<string>();
            foreach (var ingredient in clbIngredient.CheckedItems)
            {
                ingrediences.Add(ingredient.ToString());
            }
            return ingrediences;
        }

        private List<string> loadCategoriesFromDB()
        {
            //pro úèely PoC
            List<string> loadedFromDatabase = new List<string> { "Vše", "Bez lepku", "Veganské" };
            return loadedFromDatabase;
        }

        private void showingRecepies(bool vis)
        {
            cmbCategoryFilter.Visible = vis;
            clbIngredient.Visible = vis;
            btnSearchRecipes.Visible = vis;
            lstRecipes.Visible = !vis;
            btnBack.Visible = !vis;
        }

        private void loadCategories()
        {
            for (int i = 0; i < loadCategoriesFromDB().Count; i++)
            {
                cmbCategoryFilter.Items.Add(loadCategoriesFromDB()[i]);
            }
        }

        private void btnSearchRecipes_Click(object sender, EventArgs e)
        {
            searchRecipes();
            showingRecepies(false);
        }


        private void searchRecipes()
        {
            string kategorie = cmbCategoryFilter.Text;
            List<string> ingrediences = usersIngrediences();
            /* //ovìøení promìných nad touto správou
            label1.Visible = true;
            label1.Text = kategorie + ": ";
            for (int i = 0;i < ingrediences.Count; i++)
            {
                label1.Text += ingrediences[i] + " ";
            }*/

            if (kategorie == "")
            {
                kategorie = "Vše";
            }
            //pro úèely PoC
            //                           jmeno,kategorie,postup
            string[] recept1 = { "recept a", null, "postup pro recept a, který nemá kategorii" };
            string[] recept2 = { "recept b", "Bez lepku", "postup pro recept b, který je bez lepku" };
            string[] recept3 = { "recept c", "Bez lepku", "postup pro recept c, který je bez lepku" };
            string[] recept4 = { "recept d", "Veganské", "postup pro recept d, který je veganský" };
            string[] recept5 = { "recept e", "Veganské", "postup pro recept d, který je veganský" };
            string[] recept6 = { "recept f", null, "postup pro recept f, který nemá kategorii" };
            string[] ing1 = { "Rajèe", "Èesnek" };
            string[] ing2 = { "Cibule", "Èesnek" };
            string[] ing3 = { "Tìsto", "Houby" };
            string[] ing4 = { "Rajèe", "Tìsto" };
            string[] ing5 = { "Houby", "Èesnek" };
            string[] ing6 = { "Rajèe", "Cibule" };
            receptyZDatabaze = new List<string[]> { recept1, recept2, recept3, recept4, recept5, recept6 };
            ingredienceKReceptumZDB = new List<string[]> { ing1, ing2, ing3, ing4, ing5, ing6 };
            for (int i = 0; i < receptyZDatabaze.Count; i++)
            {
                if (canBeUsed(ingredienceKReceptumZDB[i], ingrediences))
                {
                    if (kategorie == "Vše")
                    {
                        lstRecipes.Items.Add(receptyZDatabaze[i][0]);
                    }
                    else
                    if (kategorie == receptyZDatabaze[i][1])
                    {
                        lstRecipes.Items.Add(receptyZDatabaze[i][0]);
                    }
                }
            }
        }

        private bool canBeUsed(string[] list, List<string> list2)
        {
            List<string> list1 = list.ToList();
            int isIn = 0;
            foreach (string itemHas in list2)
            {
                foreach (string itemNeeded in list1)
                {
                    if (itemNeeded == itemHas)
                    {
                        isIn++;
                    }
                }
            }

            if (isIn == list1.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showingRecepies(true);
            lstRecipes.Items.Clear();
        }

        private void hideAll()
        {
            btnBack.Visible = false;
            btnSearchRecipes.Visible = false;
            lstRecipes.Visible = false;
            clbIngredient.Visible = false;
            cmbCategoryFilter.Visible = false;
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string receptNazev = lstRecipes.SelectedItem.ToString();
            string[] recept = { };
            for (int i = 0; i < receptyZDatabaze.Count; i++)
            {
                if (receptNazev == receptyZDatabaze[i][0])
                {
                    recept = receptyZDatabaze[i];
                }
            }
            hideAll();
            label1.Visible = true;
            label1.Text = recept[2];
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showingRecepies(false);
            label1.Visible = false;
            button1.Visible = false;
        }
    }
}