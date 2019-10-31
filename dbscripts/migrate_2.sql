/*Script que iniciliza extensiones y los roles necesarios*/
CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

INSERT INTO "Roles"
("Id", "Name", "Active", "Created_at")
SELECT uuid_generate_v4(), 'Estudiante', true, now() at time zone 'utc'
WHERE
NOT EXISTS (
    SELECT 1 FROM "Roles" WHERE "Name" = 'Estudiante'
);

INSERT INTO "Roles"
("Id", "Name", "Active", "Created_at")
SELECT uuid_generate_v4(), 'Profesor', true, now() at time zone 'utc'
WHERE
NOT EXISTS (
    SELECT 1 FROM "Roles" WHERE "Name" = 'Profesor'
);