-- このluaスクリプトは、MA_01B900_35.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()


	--★★ケイ★★:『淘汰』の刻が、始まる
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_350002")


	--★★ケイ★★:伝承が語る終着点<br>歴史の分水嶺に引き起こされると言う…
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_350003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:それを止め、歴史をのちの世に遺すことこそ<br>継承者が果たすべき最後の責務
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_350005")

	change_face(Actor001,"Sad")

	--★★ケイ★★:だが、それを選ぶべきは…
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_350006")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
