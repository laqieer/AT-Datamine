-- このluaスクリプトは、MA_01B112_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",98.1,CharaPos110901_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_007)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力

	--★★ノワール★★:「最も<ruby=したた>強</ruby>かに、抜きん出ろ」<br>という言葉を覚えているか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020002")


	--★★ノワール★★:あんたが俺に言った言葉だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020004")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:だけどどうやら俺は<br>そこまでの速さで走り抜けられはしない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020005")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力

	--★★ニニアン★★:継承者の任命を
	Talk(Actor003,"CHRNAME_NINIAN","simple","N","MA_01B112_020007")


	--★★ニニアン★★:その枷、与える者の名は？
	Talk(Actor003,"CHRNAME_NINIAN","simple","N","MA_01B112_020009")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:妖精ニニアンは<br>継承者の資格を枷だと言う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020010")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ブルーノ★★:お前は真実を知ることになる<br>理不尽で受け入れがたい真実をな
	Talk(Actor004,"CHRNAME_BRUNO2","simple","N","MA_01B112_020012")


	--★★ブルーノ★★:「世界を救う」という選択肢を<br>放棄するかもしれない
	Talk(Actor004,"CHRNAME_BRUNO2","simple","N","MA_01B112_020014")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:父さんは俺の歩む道を<br>理不尽な真実と言う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:俺を継承者にしたのは、何故だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020017")


	--★★ノワール★★:強く頼もしい者で言えば<br>ブライアンだっていた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020018")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:世界救済の希望となるなら<br>あんたのほうが相応しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020019")


	--★★ランスロット★★:ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020020")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:『妖精殺し』の汚名を被るくらいなら<br>父さん自身が継承者になればよかったはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:お前が師匠に選ばれたんだ<br>聖杯がお前を継承者としたんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020023")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:ギネヴィアもマーリンさんも消えた<br>アーサーも守れなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020024")


	--★★ランスロット★★:俺も同じだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020026")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ランスロット★★:師匠がお前を継承者に指名した意図は<br>今となっては…俺にはわからない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020027")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが、俺は確信している<br>こうあって欲しいという祈りなのだと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:「強く生きて欲しい」という願いだと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020029")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:………ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020030")


	--★★ノワール★★:俺も、そうだと思ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020031")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:え…？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020032")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:あんたに聞いたのは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたも同じ気持ちなのか<br>確かめたかったからだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020034")


	--★★ノワール★★:抜きん出られるほどじゃない<br>だけどあんたと歩調を合わせて道を往きたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020036")

	open_select_window_tag(Actor001,"Normal","MA_01B112_020037","MA_01B112_020038")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その決断の勇気がある<br>あんたと並び立つと決めたあの日から
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どれだけ無力に打ちのめされようと<br>黒星を重ねようと、資格に相応しくなかろうと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020041")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それが最強騎士の手を取った俺の責任だ<br>だから──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020042")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:後進に道を拓くために<br>継承者としてGSを果たしたあの日から
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020044")

	change_face(Actor001,"Normal")

	--★★ノワール★★:つまずいたとしても止まれない<br>背を追う競争者が迫ってくる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020046")

	change_face(Actor001,"Normal")

	--★★ノワール★★:追われる者は脚を進め続けなきゃならない<br>その最強騎士の辛さが最近身に染みてわかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020047")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:王に忠誠を誓い、平和のために尽くし切る<br>気高き誇りを名乗りと上げる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020049")


	--★★ノワール★★:それが騎士<br>俺たちこそが騎士
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうだ、思い出せ<br>俺たちが目指した円卓の騎士とは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020052")


	--★★ノワール★★:「世界平和を叶える聖杯を探し求め<br>その聖杯へ導く妖精を守る騎士」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020053")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ランスロット★★:聖杯を見つけ、それは今お前の手のなか<br>妖精に代わるフィエナも守り切った
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020054")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:円卓の騎士が<br>聖杯探求を制したんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020055")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:反撃に歩みを進める<br>道はまだ残ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_020057")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:ふたりなら<br>脚の枷もひきずって進める
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_020058")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
