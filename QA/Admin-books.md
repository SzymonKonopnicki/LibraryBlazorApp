# Admin Books — Test Cases

## Scope
Testing CRUD operations for /admin/books (Admin role)

## TC-01: Access admin panel (as not login person)
- Steps:
	1. Go to /admin/books
- Expectd:
	Redirect to /Account/Login and information that you are not authorised
 	HTTP Request: 200 OK
- Actual:
	Redirect to /Account/Login and information 'Use a local account to log in.'
 	HTTP Request: 200 OK
- Status: PASS

## TC-02: Access admin panel (as Admin)
- Steps:
  1. Login as Admin
  2. Go to /admin/books
- Expected:
  Page loads with books table
- Actual:
	Access denied
	/Account/AccessDenied?ReturnUrl=%2Fadmin%2Fbooks
	HTTP Request 404 Not Found
- Status: FAIL

## TC-03: Access admin panel (as User)
- Steps:
  1. Login as normal User
  2. Go to /admin/books
- Expected:
	Redirect to /Account/Login and information that you are not authorised
- Actual:
	Access denied
	/Account/AccessDenied?ReturnUrl=%2Fadmin%2Fbooks
	HTTP Request 404 Not Found
- Status: FAIL