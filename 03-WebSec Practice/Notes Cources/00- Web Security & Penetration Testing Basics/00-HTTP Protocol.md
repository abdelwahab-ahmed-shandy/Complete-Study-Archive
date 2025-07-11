### 1️⃣ أساسيات بروتوكول HTTP

- **ما هو HTTP؟**
  - HTTP (بروتوكول نقل النص التشعبي) هو البروتوكول المسؤول عن نقل صفحات الويب على الإنترنت.

- **بدون حالة (Stateless):**
  - كل طلب (Request) مستقل عن الآخر، ولا يحتفظ البروتوكول بأي بيانات من الطلبات السابقة.
  - يتم تجاوز هذه المشكلة باستخدام: `Cookies` و `Sessions` و `Tokens`.

- **نموذج الطلب/الاستجابة (Request/Response):**
  - العميل (Client) يرسل طلبًا إلى الخادم (Server)، والخادم يستجيب بالبيانات المطلوبة.

- **نصي (Text-Based):**
  - رسائل HTTP قابلة للقراءة من قبل الإنسان، مما يسهل من عملية التصحيح (Debugging).

---

### 2️⃣ طرق HTTP (أفعال HTTP)

| الطريقة  | الوظيفة                               |
|----------|----------------------------------------|
| GET      | جلب بيانات من الخادم                  |
| POST     | إرسال بيانات إلى الخادم (مثل النماذج) |
| PUT      | تحديث مورد موجود على الخادم           |
| DELETE   | حذف مورد من الخادم                    |
| HEAD     | مثل GET لكن يُرجع الرؤوس فقط           |
| OPTIONS  | يعرض الطرق المدعومة للمورد            |
| PATCH    | تحديث جزئي لمورد                      |
| TRACE    | اختبار المسار إلى الخادم              |

> ملاحظة:  
> - `GET` و `POST` يُستخدمان في التطبيقات.  
> - `PUT`, `PATCH`, و `DELETE` تُستخدم عادةً في واجهات برمجة التطبيقات (APIs).

---

### 3️⃣ إصدارات HTTP

| الإصدار    | الوصف                         |
|------------|-------------------------------|
| HTTP/1.0    | أول إصدار للبروتوكول         |
| HTTP/1.1    | تحسينات في الأداء والدعم      |
| HTTP/2      | دعم لتعدد الطلبات بشكل أسرع   |
| HTTP/3      | أسرع وأكثر أمانًا باستخدام QUIC |

---

### 4️⃣ أكواد استجابة HTTP

| الفئة  | المعنى                          |
|--------|---------------------------------|
| 1xx    | معلومات                         |
| 2xx    | نجاح                            |
| 3xx    | إعادة توجيه                     |
| 4xx    | خطأ من جهة العميل               |
| 5xx    | خطأ من جهة الخادم               |

**أشهر الأكواد:**
- `200 OK` – تم بنجاح  
- `302 Found` – تم العثور على مورد  
- `400 Bad Request` – طلب غير صالح  
- `403 Forbidden` – مرفوض  
- `404 Not Found` – غير موجود  
- `500 Internal Server Error` – خطأ داخلي في الخادم  











---

## 🌐 HTTP Protocol and Sessions

### 1️⃣ HTTP Protocol Essentials

- **What is HTTP?**
  - HTTP (HyperText Transfer Protocol) is the main protocol for transferring web pages over the internet.

- **Stateless:**
  - Each request is independent and does not retain information about previous requests.
  - This issue is mitigated using `Cookies`, `Sessions`, and `Tokens`.

- **Request/Response Model:**
  - The client sends a request to the server, and the server responds with the requested data.

- **Text-Based:**
  - HTTP messages are human-readable, making them easy to debug.

---

### 2️⃣ HTTP Methods (Verbs)

| Method   | Description                                |
|----------|--------------------------------------------|
| GET      | Retrieve data from the server              |
| POST     | Send data to the server (e.g., forms)      |
| PUT      | Update a resource on the server            |
| DELETE   | Remove a resource from the server          |
| HEAD     | Like GET but returns headers only          |
| OPTIONS  | Lists allowed methods for the resource     |
| PATCH    | Partial update of a resource               |
| TRACE    | Loop-back test along the request path      |

> Note:  
> - `GET` and `POST` are mainly used in applications.  
> - `PUT`, `PATCH`, and `DELETE` are typically used in APIs.

---

### 3️⃣ HTTP Versions

| Version    | Description                            |
|------------|----------------------------------------|
| HTTP/1.0   | The first version of HTTP              |
| HTTP/1.1   | Improved performance and capabilities  |
| HTTP/2     | Faster, supports multiplexing          |
| HTTP/3     | Faster and more secure (uses QUIC)     |

---

### 4️⃣ HTTP Response Status Codes

| Category | Meaning                  |
|----------|--------------------------|
| 1xx      | Informational            |
| 2xx      | Success                  |
| 3xx      | Redirection              |
| 4xx      | Client Error             |
| 5xx      | Server Error             |

**Common Codes:**
- `200 OK` – Success  
- `302 Found` – Resource Found  
- `400 Bad Request` – Invalid Request  
- `403 Forbidden` – Access Denied  
- `404 Not Found` – Resource Not Found  
- `500 Internal Server Error` – Server-side Failure  

---

### By Abdelwahab Shandy 