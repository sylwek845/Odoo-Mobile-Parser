# Odoo-Mobile-Parser
Parse Odoo Module to Creates all classes and fields in mobile project

Tested only with Odoo 10!


How to use it.

* You can only parse one model at same time.

1. Go to Settings and Activate the developer mode
2. In Technical find Database Structure and Fields.
3. Use search/filter to find only fileds from model that you want to create.
4. Select fields you want to parse (make sure to not mark odoo base fields eg. write_date,id etc)
5. Click on Action and Export
6. Use CSV Format.
7. Select following fields [required],[model],[relation],[name],[ttype],[field_description],[relation_field],[relation_table] and save it for later ;).
8. Click Export to File and save the file.

Open the Odoo Mobile Parser exe
1. Select CSV file.
2. Select Project Path eg (C:\Users\%User%\StudioProjects\Odoo-Mobile)
3. Type your model folder name eg HR.
4. Click on update, and your package name should appear in box above.
5. Click Parse and check your parse module.
6. If you happy with results click save and all files should appear in your Android Project.

Any problems ? Use Issues at github ;) or email me at sylwester.zalewski845@gmail.com.

Feels free to send me some suggestions or just feedback.
