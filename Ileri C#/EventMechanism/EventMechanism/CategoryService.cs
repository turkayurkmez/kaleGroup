using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanism
{
    //1. Kim (hangi nesne) olayı fırlatacak?
    public class CategoryService
    {
        //3. Olay nasıl bir metot taraçfından yakalanacak?
        public delegate void CategoryAddedEventHandler (object sender, CategoryAddedEventArgs e);
        //5. Event tanımı nasıl olacak
        public event CategoryAddedEventHandler CategoryAdded;
        public void AddCategory(Category category)
        {
            //2. Ne zaman?
            //veritabanına eklendiğini hayal ediyoruz....
            //ekleme başarılı olduktan sonra buarada event fırlayacak!
            
            CategoryAddedEventArgs eventArgs = new CategoryAddedEventArgs { NewCategory = category, CreatedBy = "turkay", CreatedDate = DateTime.UtcNow };

            //6. Event yakalanmış ise fırlat:
            OnCategoryAdded(eventArgs);
        }

        protected virtual void OnCategoryAdded(CategoryAddedEventArgs eventArgs)
        {
            //7. Event += ile bind edilmiş ise:
            if (CategoryAdded != null)
            {
                //8. Event'i fırlat.
                CategoryAdded(this, eventArgs);
            }
        }


    }



}
