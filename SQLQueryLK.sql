CREATE PROCEDURE usp_InsertarEspecialista
(
    @EspecialistaCMP INT,
    @EspecialistaNombre VARCHAR(30),
    @EspecialistaApellido VARCHAR(50),
    @EspecialidadCodigo INT
)
AS
BEGIN
    BEGIN TRY
        INSERT INTO Especialista (EspecialistaCMP, EspecialistaNombre, EspecialistaApellido, EspecialidadCodigo)
        VALUES (@EspecialistaCMP, @EspecialistaNombre, @EspecialistaApellido, @EspecialidadCodigo)
    END TRY
    BEGIN CATCH
        SELECT ERROR_NUMBER(), ERROR_MESSAGE()
    END CATCH
END

CREATE PROCEDURE usp_EliminarEspecialista
(
    @EspecialistaCMP INT
)
AS
BEGIN
    BEGIN TRY
        DELETE FROM Especialista WHERE EspecialistaCMP = @EspecialistaCMP
    END TRY
    BEGIN CATCH
        SELECT ERROR_NUMBER(), ERROR_MESSAGE()
    END CATCH
END

CREATE PROCEDURE usp_ActualizarEspecialista
(
    @EspecialistaCMP INT,
    @EspecialistaNombre VARCHAR(30),
    @EspecialistaApellido VARCHAR(50),
    @EspecialidadCodigo INT
)
AS
BEGIN
    BEGIN TRY
        UPDATE Especialista
        SET
            EspecialistaNombre = @EspecialistaNombre,
            EspecialistaApellido = @EspecialistaApellido,
            EspecialidadCodigo = @EspecialidadCodigo
        WHERE
            EspecialistaCMP = @EspecialistaCMP
    END TRY
    BEGIN CATCH
        SELECT ERROR_NUMBER(), ERROR_MESSAGE()
    END CATCH
END


