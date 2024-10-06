-- このluaスクリプトは、MA_01B900_57.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★クレア★★:隠された真実など<br>足を引っ張るだけだと思っていたけれど
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B900_570002")


	--★★ボールス★★:枷すら武器と化したな<br>お前たちは
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B900_570003")


	--★★クレア★★:世の中<br>「知らなければ良かった」と思う謎の方が多いわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B900_570004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★クレア★★:実際…暴いた『本当』の分だけ<br>あなたは傷つき、歩みを遅くした
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B900_570005")


	--★★ボールス★★:それでも『本当』を<br>見て見ぬふりすることはなかった
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B900_570006")

	change_face(Actor003,"Normal")

	--★★クレア★★:事の真相自体に値付けはできないけれど<br>間違いなく誇るべきはそこに辿り着くまでの道程
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B900_570007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★クレア★★:たとえ追いかけ続けた先が<br>喪われたのだとしても──
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B900_570008")


	--★★ボールス★★:これまでの道のりで<br>強く鍛え上げられた脚にすべては遺る
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B900_570009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ボールス★★:振り上げた腕の疲れが…早まる鼓動が<br>道の長さと険しさと、至るまでの憧れを語る
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B900_570010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ボールス★★:歩み続ける意志こそ
	Talk(Actor002,"CHRNAME_BORS","speech","L","MA_01B900_570012")

	change_face(Actor003,"Smile")

	--★★クレア★★:あなたを本当に<br>前へと進ませるはず
	Talk(Actor003,"CHRNAME_CLARE","speech","L","MA_01B900_570014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
