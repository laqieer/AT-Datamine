-- このluaスクリプトは、MA_01104_113.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",147.5954,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_024_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
-- ▼直接出力
load_image("103010300", "content_still_10301030_image", "103010300_StillImage")
DontChangeRandomCamera(true)
set_pos(Actor001,{-0.239,1.71,-20.165})
show_image("103010300",0.0,0.0,0.0,true,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111017)
	Actor001 = InitializeCharacter_3D("101058","001","101058001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
hide_image(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力

	--★★ライエンス王★★:元々が粗末な民を餌にした程度では<br>粗悪なものにしかならぬか
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_1130003")


	--★★ライエンス王★★:<ruby=ランスロット>最強騎士</ruby>が帰還したとなると<br>もはや襲撃は兵の無駄…
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_1130004")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ライエンス王★★:まあ良し<br>聖杯が現れるまでは精々──
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_1130006")

	change_face(Actor001,"Smile")

	--★★ライエンス王★★:<ruby=サークル>円卓</ruby>の活動を愉しめ
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_1130007")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103010300", "content_still_10301030_image", "103010300_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111017)
	InitializeCharacter_3D_Preload("101058","001","101058001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
