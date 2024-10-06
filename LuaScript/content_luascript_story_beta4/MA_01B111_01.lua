-- このluaスクリプトは、MA_01B111_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
se_play("SE_ADV_MA_01C109_01_Bell")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:放課後、お忙しい？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010002")

-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:忙しそうだな、ギネヴィアは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:しつっこいんだから、ローマの奴ら<br>もおヘトヘト
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B111_010005","MA_01B111_010006","MA_01B111_010007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺に出来ることはある？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_010009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:聖杯を早く発見あそばせ<br>そうしたら、わたしたちみんな幸せ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010010")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:期待しちゃうからね<br>大帝国すら覆す奇跡の一手になることを
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:頑張れ、殿下
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_010013")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:丸投げは酷いわねえ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010014")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:でも…任された
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん、今日は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_010017")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:そうよねえ。継承者様はお忙しいわよねえ<br>来賓の相手だったり世界の行く末を考えたり
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010018")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…わ、わかったよ<br>少しの時間で良ければ付き合うから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_010019")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:無理を聞いてもらっちゃったみたいで<br>ごめんなさいね。にししっ♪
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010020")

	goto Block1end

::Block1end::
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そおんな与太話はいーのよ<br>ね。ね。ノワール、デートしようよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010022")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、忙しいんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_010023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:にっしっし♪<br>わたしだと思った？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010024")


	--★★ギネヴィア★★:アナタのボーイフレンドがお呼びよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01B111_010025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 1
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
