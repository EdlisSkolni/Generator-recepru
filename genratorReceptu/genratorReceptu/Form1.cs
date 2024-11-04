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
            //pro ��ely PoC
            List<string> loadedFromDatabase = new List<string> { "Raj�e", "Cibule", "�esnek", "Houby", "T�sto" };
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
            //pro ��ely PoC
            List<string> loadedFromDatabase = new List<string> { "V�e", "Bez lepku", "Vegansk�" };
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
            /* //ov��en� prom�n�ch nad touto spr�vou
            label1.Visible = true;
            label1.Text = kategorie + ": ";
            for (int i = 0;i < ingrediences.Count; i++)
            {
                label1.Text += ingrediences[i] + " ";
            }*/

            if (kategorie == "")
            {
                kategorie = "V�e";
            }
            //pro ��ely PoC
            //                           jmeno,kategorie,postup
            string[] recept1 = { "recept a", null, "postup pro recept a, kter� nem� kategorii" };
            string[] recept2 = { "recept b", "Bez lepku", "postup pro recept b, kter� je bez lepku" };
            string[] recept3 = { "recept c", "Bez lepku", "postup pro recept c, kter� je bez lepku" };
            string[] recept4 = { "recept d", "Vegansk�", "postup pro recept d, kter� je vegansk�" };
            string[] recept5 = { "recept e", "Vegansk�", "postup pro recept d, kter� je vegansk�" };
            string[] recept6 = { "recept f", null, "postup pro recept f, kter� nem� kategorii" };
            string[] ing1 = { "Raj�e", "�esnek" };
            string[] ing2 = { "Cibule", "�esnek" };
            string[] ing3 = { "T�sto", "Houby" };
            string[] ing4 = { "Raj�e", "T�sto" };
            string[] ing5 = { "Houby", "�esnek" };
            string[] ing6 = { "Raj�e", "Cibule" };
            receptyZDatabaze = new List<string[]> { recept1, recept2, recept3, recept4, recept5, recept6 };
            ingredienceKReceptumZDB = new List<string[]> { ing1, ing2, ing3, ing4, ing5, ing6 };
            for (int i = 0; i < receptyZDatabaze.Count; i++)
            {
                if (canBeUsed(ingredienceKReceptumZDB[i], ingrediences))
                {
                    if (kategorie == "V�e")
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