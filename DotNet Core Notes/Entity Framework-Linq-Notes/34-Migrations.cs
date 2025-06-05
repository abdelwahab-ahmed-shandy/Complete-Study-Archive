// After finishing creating the files, classes and connections, we will now create the three actual bases, 
// so before that we have to create some migrations in which we can see the complete data base before creating it,
// so here are some commands that will help you in this matter

Migrations :
===============

Add-Migration CommentwithMirgration // يُستخدم هذا الأمر لإضافة ترحيل جديد باسم AddNewTables

Update-DataBase // يُحدث قاعدة البيانات لتتماشى مع أحدث ترحيل

Remove-Migration //يزيل آخر ترحيل تم إنشاؤه

Script-Migration // يُستخدم لإنشاء سكربت SQL يعكس التغييرات بين هجرتين في Entity Framework Core

Script-Migration AddNewTables //يُنشئ سكريبت SQL يبدأ من ترحيل معين (AddNewTables) وينتهي بأحدث ترحيل

Script-Migration AddNewTables AddAuditTable // يُنشئ سكريبت SQL يبدأ من ترحيل محدد (AddNewTables) وينتهي بترحيل آخر (AddAuditTable)

Get-Migration // يُعرض قائمة بجميع الترحيلات التي تم إنشاؤها 

Get-Package  //  استخدم الأمر التالي لعرض قائمة الحزم المثبتة

