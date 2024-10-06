-- このluaスクリプトは、CO_101011_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
lookAtWeight = {0.4, 0.08, 0.7, 0.6}
keep_ik_lookat(Actor003, Actor002, "J_Head")
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…すごい賑わいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020002")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力

	--★★ギネマウア★★:ロンディニウムの都の近くには<br>大きな港があって
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020003")


	--★★ギネマウア★★:島の内外から<br>さまざまなものが集まりますからね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:それを求めて<br>人もたくさんやってきます
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:ねえねえ、ノワール<br>今日はどこに行ってみる？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_03020008","CO_101011_03020009","CO_101011_03020010")
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
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:向こうの広場に大道芸人が<br>来ているみたいだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:行ってみないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020013")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:さんせー！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あのパントマイムっていうの面白かったわね<br>本当に目の前にカベがあるみたいだった！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:剣をアゴの上に乗せた状態でのジャグリングも<br>すごかったなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020018")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの技術<br>真似して戦闘に活かせないかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020019")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:ふふっ<br>ふたりとも子供みたいにはしゃいで
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020021")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:お姉ちゃんだって、カードを使った手品に<br>目をキラキラさせてたじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020022")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:させてません
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020023")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:させてましたー
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020024")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor001,"to  Std_Talk")
PlayActionDirect(Actor002,"to  Std_Talk")
PlayActionDirect(Actor003,"to  Std_Yes")
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おっと、あんまり同じ場所に立ち止まってると<br>他のお客さんの迷惑になるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そうね、移動しましょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ちょっとハラが減ったな<br>なにか珍しい食べ物でもないかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020029")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:向こうに屋台が並んでいるみたい<br>行ってみる？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020030")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
fadein(FADE_TIME)
wait_time(FADE_TIME)
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:はーっ<br>もう食べられない…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ログレスでは見たことのない<br>食べ物も多かったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020033")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:帰ったらアーサーに<br>教えてやろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020034")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん、俺はこの都に詳しくないからな<br>キミに任せるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020036")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:よーし、任されたわ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020037")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:どう？<br>ギネヴィア・ツアーズの感想は
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020039")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:短時間であんなに<br>たくさんの場所を回れるとは思わなかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020040")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ロンディニウム観光を<br>満喫できたでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、おかげさまで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020042")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:また今度、お願いしようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020043")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ご予約、承りました～♪
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020044")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう、ギネヴィア<br>リフレッシュできた気がするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:どういたしまして
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020047")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:今日はわたしも遊び疲れちゃった<br>そろそろ帰ろっか
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020049")

-- ▼直接出力
se_play("SE_ADV_CO_101011_0202_Bodyfall")
PlayPartVoice("ギネヴィア", "苦しみ")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★ギネヴィア★★:おぶっ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","CO_101011_03020051")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんでなにもないところで<br>転ぶんだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020053")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	close_cutin()
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:想像していた以上に<br>疲れちゃってたみたい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020054")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:もう歩けなーい<br>歩きたくなーい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020055")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --set_common_look_at(Actor002,Actor003)
set_enable_auto_lookat(Actor002, false)
turn(Actor002,0, 193, 0, 0.5)
lookat_delay_weight(Actor002, {1.0, 0, 0.5, 0.5} ,0.5)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力

	--★★ギネヴィア★★:…おんぶ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:ダメです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020058")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:えーっ<br>昔はやってくれたじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020059")


	--★★ギネマウア★★:ダメ<br>いくつになったと思ってるの
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力

	--★★ギネヴィア★★:…泣いちゃうよ、わたし？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020062")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力

	--★★ギネマウア★★:泣いてもダメ
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020063")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:…それに約束したでしょ<br>もう泣かないって
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020064")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,1.0)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ぶーっ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020065")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
lookat_delay_weight_reset(Actor002,0.3)
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:仲がいいんだな<br>さすが姉妹
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03020067")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:とーぜんよ<br>今はふたりきりの家族だもの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020068")

-- ▼直接出力
 --set_common_look_at(Actor002,Actor003)
lookat_delay_weight(Actor002, {1.0, 0, 0.5, 0.5} ,1.0)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ずっと一緒<br>ね？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03020069")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:そうね<br>ずっと一緒
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_03020070")

-- ▼直接出力
local trustParam = set_communication_rankup("ギネヴィア_コミュランク", "ギネヴィア_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
lookAtWeight = {0.4, 0.08, 0.7, 0.6}
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
