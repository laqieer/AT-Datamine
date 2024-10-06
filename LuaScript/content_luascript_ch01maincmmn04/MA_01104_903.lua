-- このluaスクリプトは、MA_01104_903.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()


	--★★ケイ★★:ノワールか<br>先のバルバロイ掃討作戦の働きは聞いている
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9030002")


	--★★ノワール★★:もう連絡が届いてるのか<br>早いな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:今後も見習いとして<br>憲兵団の任務を手伝わせてもらおうと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9030004")

	change_face(Actor002,"Anger")

	--★★ケイ★★:円卓の騎士として参加するのだ<br>くれぐれも恥ずかしい行いはしてくれるなよ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9030005")

	change_face(Actor002,"Normal")

	--★★ケイ★★:それから私だけでなく<br>情報屋への報告も忘れぬようにな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01104_9030006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ、そうだった<br>すぐに行ってくるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9030007")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
