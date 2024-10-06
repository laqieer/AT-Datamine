-- このluaスクリプトは、MA_01B110_44.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_018,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_018)
	Camera007 = SetTemplate("Actor007",170,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("10102020", "content_still_10102020_image", "101020200_StillImage")
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor001,0.6,0.03,0.7,0)
lookat_weight(Actor003,0.6,0.03,0.7,0)
lookat_weight(Actor002,0.6,0.03,0.7,0)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力

	--★★パーシヴァル★★:それじゃあ聞かせてよ<br>聖杯が見つからないことへのテイの良い言い訳を
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_440002")

-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:…パーシヴァル卿<br>姉上への侮辱はガラハッドが許さないぞ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440003")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力

	--★★ヴォールス★★:パーシヴァルがこういった物言いをするのは<br>人に頼ることを恥と考えているからだろう
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_440005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴォールス★★:逆に言えばフィエナをそれだけ頼りにしている…<br>ということだ、すまぬが寛容に接してやってくれ
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_440006")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Anger")

	--★★パーシヴァル★★:ぼ、ボクを面倒な奴扱いするな！！<br>は、は、歯がゆいだけさ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01B110_440007")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B110_440008","MA_01B110_440009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:みんなやれることをやってる<br>フィエナもガラハッドも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_440011")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ノワール…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろんパーシヴァルも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_440013")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:そうさ！ハイハイ！<br>だから当てこすりはやめろっていうんだろ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_440014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:気持ちはわかる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_440016")

	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:そうだろう！？<br>あっちこっちに飛び回らされてさ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_440017")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ランスロット★★:だとしてもフィエナがいなければ<br>俺たちにはなんの手掛かりもない
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01B110_440018")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ヴォールス★★:素直に頼るべきだと思うがな
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_440019")

	goto Block1end

::Block1end::
-- ▼直接出力
lookat_weight(Actor001,0.5,0.03,0.7,0)
set_enable_auto_lookat_all(true)
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★フィエナ★★:聖杯がどうして見つからないのか<br>その理由は──
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440021")

-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor006,true)
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★フィエナ★★:…敵が在処を隠しているから<br>なんじゃないかと思うの
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440022")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:隠す…<br>どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_440024")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★フィエナ★★:…前に私、継承者の覚醒とともに<br>聖杯の出現を感じたって言ったでしょ？
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440025")

	PlayAction(Actor006,"to  Std_No")
	change_face(Actor006,"Sad")

	--★★フィエナ★★:だけどその反応はすぐに消えたの<br>恐らくは何者かによって抑え込まれたカタチで
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440026")

	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Anger")

	--★★マーリン★★:状況から考えれば<br>魔女姉妹がその原因…でしょうか？
	Talk(Actor007,"CHRNAME_MERLIN","speech","L","MA_01B110_440028")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★フィエナ★★:そう！…なんじゃないかと思うの<br>魔女が聖杯の再出現を封印しているのかもって…
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440029")

	change_face(Actor006,"Anger")

	--★★フィエナ★★:封印を維持するにも<br>なにかしらの条件が必要なはず
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440030")


	--★★フィエナ★★:魔女の力を活性化させる力場があるのか<br>地脈に恵まれている必要があるのか
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:た、確かに今まで向かった3か所すべてで奴らは<br>なんらかの儀式を行っているようだった…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440032")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:うん。だから聖杯に作用する魔女から<br>聖杯に近い反応を感じても不思議じゃない
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440033")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力

	--★★ガラハッド★★:ま、待ってください姉上<br>もし仮にそうだとして──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440034")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:聖杯の在処を魔女たちが隠しているとするなら<br>なぜ魔女たちが聖杯を使おうとしないのです…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440035")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "照れ")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★パーシヴァル★★:そ、そうだよねー！？おかしいと思ったよ！<br>聖杯は願いごとを叶えるアイテムなんだろ！？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_440036")

	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:その出現を封印する、なんて面倒な真似しないで<br>ササッとゲットして使っちゃえばさあ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_440037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "苦しみ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★フィエナ★★:………そこ、なんだよねえ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440039")

-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴォールス★★:なにか別の狙いがある…？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_440040")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight_reset(Actor001,1)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………「聖杯は願いを叶えるものにあらず」？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_440042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力

	--★★ガラハッド★★:ノワール…？<br>なんだそれは？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440044")


	--★★ノワール★★:…聖杯は、なんらかの理由で敵には扱えない<br>だから別の方法で利用しようとしている…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_440045")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:………そう、考えるのが妥当かもしれませんね
	Talk(Actor007,"CHRNAME_MERLIN","speech","L","MA_01B110_440046")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★フィエナ★★:あ、ここからはね？フィエナちゃんの一方的な<br>本当に勝手な祈りっていうか妄想なんだけど…
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440047")

	change_face(Actor006,"Sad")

	--★★フィエナ★★:おじいちゃんは私たちが有利になるように<br>仕向けてくれてるんじゃないかなって…
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440048")


	--★★ガラハッド★★:お、お爺様が…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440049")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:………あながち、あり得ない話でも<br>ないかもしれないな
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01B110_440050")

	PlayAction(Actor006,"to  Std_No")

	--★★フィエナ★★:おじいちゃんの狙いがなんなのか、全然…<br>全然わかんない今、楽観的かもしれないけど
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440051")


	--★★フィエナ★★:魔女にいいようにされながらも<br>魔女を倒させるようにしてくれたりとか…
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440052")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力

	--★★パーシヴァル★★:…仮に、だとすればさ<br>ボクらはあといくつ封印を解く必要があるのさ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B110_440053")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight_reset(Actor002,1)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:………お爺様が、言ってた<br>「卓の脚は4本が良い」と
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:3本でもいいけど<br>4本の方がいいって言ってた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440056")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:…確かに、重いものを置く卓は<br>4本脚の方が安定して好ましいな
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_440057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Surprise")

	--★★パーシヴァル★★:な、なんの話ィ？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01B110_440058")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★フィエナ★★:聖杯の封印も、多分同じだよ<br>安定して聖杯の出現を抑制するためには──
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B110_440059")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:4か所で封印を行う必要がある…<br>お爺様はそうヒントをくれてるんだ…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B110_440060")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10102020", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
voiceSignalS = voice_play("VO_MA_01B110_440061")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10102020", "content_still_10102020_image", "101020200_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
