-- このluaスクリプトは、MA_01A109_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_006)
	Camera002 = SetTemplate("Actor002",-148,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
-- ▲直接出力
-- ▼直接出力
tegami_offset2 = {0,0,0,0,0,0}
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera007)
PlayActionDirect(Actor001,"to ReadLetter")
SkipDefaultMotion(Actor001)
on_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
-- ▲直接出力

	--★★テロップ★★:「先代ログレス王ユーサーの治世は<br>ＧＳの独占によって成り立ったものだ」
	Talk(Actor003,"telop","narration","N","MA_01A109_260002")


	--★★テロップ★★:「ユーサーはこともあろうにその力を囲い込み<br>ローマ人のすべてを見捨て…」
	Talk(Actor003,"telop","narration","N","MA_01A109_260003")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + FADE_AFTER_TIME)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フレン★★:「バルバロイにローマ人を喰らわせた」…？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A109_260004")

	change_face(Actor002,"Sad")

	--★★ローラ★★:お姉ちゃん…？<br>この手紙、どこで──
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A109_260005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★フレン★★:…机に、入ってたの
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A109_260006")


	--★★テロップ★★:「ユーサーがブリテンを支配するためには<br>ローマ人はただの邪魔でしかなかった」
	Talk(Actor003,"telop","narration","N","MA_01A109_260007")


	--★★テロップ★★:「ユーサーはブリテンを救う力を持ちながら<br>むしろ好機とばかりに静観を決め込み…」
	Talk(Actor003,"telop","narration","N","MA_01A109_260008")


	--★★テロップ★★:「当時ブリテン全土に住まうローマ人が<br>バルバロイに喰われ尽くすのを待った」
	Talk(Actor003,"telop","narration","N","MA_01A109_260009")

	PlayAction(Actor002,"to  Std_No")

	--★★ローラ★★:「まるで、虐殺だ」………
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01A109_260010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:ルーシャスくんの、字なんだ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A109_260011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10106003)
tegami_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
