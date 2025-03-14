/*
=============================================================
                📌 ASP.NET Identity - Summary
=============================================================
*/

// ✅ جدول المستخدمين (AspNetUsers)
// يحتوي على بيانات المستخدمين المسجلين في النظام.
// 🔹 أهم الحقول:
// - Id: معرف المستخدم الفريد (GUID).
// - UserName: اسم المستخدم.
// - Email: البريد الإلكتروني.
// - PasswordHash: كلمة المرور مشفرة.
// - LockoutEnabled: هل يمكن قفل الحساب بعد محاولات فاشلة؟

// ✅ جدول الأدوار (AspNetRoles)
// يخزن الأدوار (Roles) التي يمكن تعيينها للمستخدمين، مثل "Admin" و "User".
// 🔹 أهم الحقول:
// - Id: معرف الدور الفريد (GUID).
// - Name: اسم الدور.

// ✅ جدول العلاقة بين المستخدمين والأدوار (AspNetUserRoles)
// يمثل العلاقة بين المستخدمين والأدوار بطريقة Many-to-Many.
// 🔹 أهم الحقول:
// - UserId: معرف المستخدم.
// - RoleId: معرف الدور.

// ✅ جدول المطالبات (AspNetUserClaims)
// يُستخدم لتخزين مطالبات مخصصة لكل مستخدم (Claims).
// 🔹 أهم الحقول:
// - Id: معرف المطالبة.
// - UserId: معرف المستخدم المرتبط بالمطالبة.
// - ClaimType: نوع المطالبة (مثل "Department").
// - ClaimValue: قيمة المطالبة (مثل "IT Department").

// ✅ جدول تسجيل الدخول بمزودات خارجية (AspNetUserLogins)
// يخزن بيانات تسجيل الدخول باستخدام مزودات خارجية مثل Google أو Facebook.
// 🔹 أهم الحقول:
// - LoginProvider: اسم مزود تسجيل الدخول.
// - ProviderKey: معرف المستخدم في المزود الخارجي.
// - UserId: معرف المستخدم في قاعدة البيانات.

// ✅ جدول التوكنات (AspNetUserTokens)
// يُستخدم لتخزين التوكنات الخاصة بالمستخدمين، مثل إعادة تعيين كلمة المرور أو المصادقة الثنائية.
// 🔹 أهم الحقول:
// - UserId: معرف المستخدم.
// - LoginProvider: مزود التوكن.
// - Name: اسم التوكن.
// - Value: قيمة التوكن.

/*
=============================================================
                 🎯 أمثلة عملية على الاستخدام
=============================================================
*/

// 🔥 إضافة مستخدم إلى دور معين
public async Task AddUserToRole(UserManager<IdentityUser> userManager, string email, string role)
{
    var user = await userManager.FindByEmailAsync(email);
    if (user != null)
    {
        await userManager.AddToRoleAsync(user, role);
    }
}

// 🔍 التحقق مما إذا كان المستخدم لديه دور معين
public async Task<bool> IsUserInRole(UserManager<IdentityUser> userManager, string email, string role)
{
    var user = await userManager.FindByEmailAsync(email);
    return user != null && await userManager.IsInRoleAsync(user, role);
}

/*
=============================================================
                        📝 الخلاصة
=============================================================
*/

AspNetUsers: يخزن بيانات المستخدمين.
AspNetRoles: يخزن الأدوار المتاحة.
AspNetUserRoles: يربط المستخدمين بالأدوار.
AspNetUserClaims: يستخدم لإضافة معلومات إضافية لكل مستخدم.
AspNetUserLogins: يخزن بيانات تسجيل الدخول عبر Google, Facebook.
AspNetUserTokens: يخزن التوكنات للمستخدمين.
