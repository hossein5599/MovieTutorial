
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieDialog extends Serenity.EntityDialog<MovieRow, any> {
        protected getFormKey() { return MovieForm.formKey; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getNameProperty() { return MovieRow.nameProperty; }
        protected getService() { return MovieService.baseUrl; }
        protected getDeletePermission() { return MovieRow.deletePermission; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getUpdatePermission() { return MovieRow.updatePermission; }

        protected form = new MovieForm(this.idPrefix);

        constructor() {
            super();
                     //this.form.MyOption.change(e => {
            //    let currentValue = Serenity.EditorUtils.getValue(this.form.MyOption);
            //    //let currentText = Serenity.EnumFormatter.format(MyEnum, Q.toId(currentValue));

            //    //Q.notifySuccess(`You selected ${currentText}, lookup items will be reloaded`);

            //    // clear old value
            //    this.form.TestLookup.value = null;

            //    // pass value into lookup editor and update items
            //    this.form.TestLookup.myId = currentValue;
            //    this.form.TestLookup.updateItems();

            //    // select first lookup item after changing
            //    if (this.form.TestLookup.items && this.form.TestLookup.items.length > 0) {
            //        Serenity.EditorUtils.setValue(this.form.TestLookup, this.form.TestLookup.items[0].id);
            //    }
            //});
        }


        afterLoadEntity() {
            super.afterLoadEntity();

            

        }

        onDialogOpen() {

        }


        validateBeforeSave(): boolean {

            var res = super.validateBeforeSave();

            // ..... and res
            if (this.form.Title.value == "safda" && res) {
                // Q.notifyWarning();
                return false;
            }

            return true;

        }

        

    }
}