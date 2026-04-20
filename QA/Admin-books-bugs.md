## BUG-01: Unauthorized user can access admin panel

- Description:
  Normal user can access /admin/books

- Steps:
  1. Login as User
  2. Go to /admin/books

- Expected:
  Access denied (403) or not authorized

- Actual:
  User can access admin panel

- Severity: HIGH

- Priority: HIGH

- Status: OPEN