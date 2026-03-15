--of course it's only for testing connection, not for prod :)
--changes in this file require docker compose down -v 
create table USERS(
	id int PRIMARY KEY,
	first_name varchar(50),
	last_name varchar(50),
	email varchar(300),
	verified bool,
	password varchar(512)
);
create table AUCTIONS (
	auction_id int PRIMARY KEY,
	owner_id int references users(id),
	start_date timestamp,
	end_date timestamp,
	last_bidder int references users(id),
	last_bid int,
	start_bid int,
	next_bid_change int
);
insert into users (id,first_name,last_name,email,verified,password) values (1,'Michael','Aston', 'aston@mat.umk.pl',false,'temp');
insert into users (id,first_name,last_name,email,verified,password) values (2,'Simon','Cyceron', 'cyceron@umk.pl',false,'temp');
insert into users (id,first_name,last_name,email,verified,password) values (3,'Karim','Benzine', 'karim@a.pl',false,'temp');
insert into auctions (auction_id,owner_id, start_date, end_date, last_bidder, last_bid, start_bid, next_bid_change) values (1, 1, '2026-03-14 20:15:00','2026-05-14 20:15:00',2,200,100,50);
insert into auctions (auction_id,owner_id, start_date, end_date, last_bidder, last_bid, start_bid, next_bid_change) values (2, 2, '2026-02-14 10:15:00','2026-04-14 10:15:00',1,400,200,100);