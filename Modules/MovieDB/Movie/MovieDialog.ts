
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