--of course it's only for testing connection, not for prod :)

create table USERS(
	id int PRIMARY KEY,
	first_name varchar(50),
	last_name varchar(50),
	email varchar(300),
	verified bool,
	password varchar(512)
);
create table auctions (
	auction_id int PRIMARY KEY,
	owner_id int references users(id),
	start_date timestamp,
	end_date timestamp,
	last_bidder int references users(id)
);
insert into users (id,first_name,last_name,email,verified,password) values (1,'Michael','Aston', 'aston@mat.umk.pl',false,'temp');
insert into users (id,first_name,last_name,email,verified,password) values (2,'Simon','Cyceron', 'cyceron@umk.pl',false,'temp');