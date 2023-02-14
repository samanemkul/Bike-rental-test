create table add_payment(
	BikeNo int not null,
	PaymentType varchar(255) not null,
	PaidBy varchar(255) not null,
	PaymentDate date not null,
	Remarks varchar(255) not null
	);
	select * from add_payment