Create Trigger dbo.tr_bpkb_location ON dbo.tr_bpkb After Insert, Update
As
Begin

   If NOT Exists(select location_id from MasterDB..ms_storage_location where location_id in (Select location_id from inserted))
   BEGIN
      RAISERROR('Location is not found!',11,1)
   END

END