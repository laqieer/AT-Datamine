-- このluaスクリプトは、CO_101001_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",50,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",78,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
 --白背景読込
 load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_HolyGrail")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Remains")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101030011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101001","002","101001002")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ここか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:見たところ<br>なにも残っていないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030003")


	--★★ノワール★★:すでに残党が持ち去ったか<br>あるいは他の盗賊団に奪われたか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:これは…？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030006")

-- ▼直接出力
bgm_play("BGM_ADV_HolyGrail")
-- ▲直接出力
-- ▼直接出力
 --白背景に移行
CloseTalkWindow()
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング2★★:私の肖像画…ですか？
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","CO_101001_08030009")


	--★★子供（女）★★:ああ<br>……うちにキミの姿を残しておきたいんだ！
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030011")


	--★★子供（女）★★:……が……なんて知らなかった<br>だったら、絶対に残しておかなきゃ
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030013")


	--★★子供（女）★★:……を救ってくれた恩人の姿をね
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030015")


	--★★子供（女）★★:安心してほしい<br>ちゃんと綺麗に描くから
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ティルフィング2★★:ふふっ<br>そこは心配していませんよ
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","CO_101001_08030018")


	--★★ティルフィング2★★:…では、お願いします
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","CO_101001_08030019")


	--★★子供（女）★★:よし<br>それじゃ、そこに立ってくれ
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030020")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101001_0803_Portrait_Writing")
-- ▲直接出力

	--★★子供（女）★★:…
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030022")

-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_CO_101001_0803_Portrait_Writing")
-- ▲直接出力

	--★★子供（女）★★:……
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030024")

-- ▼直接出力
wait_time(3.8)
-- ▲直接出力

	--★★子供（女）★★:…ティル、フィング？
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030026")

-- ▼直接出力
PlayPartVoice("ティルフィング", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ティルフィング2★★:…どうやら<br>お別れの、ようで、す…
	Talk(Actor003,"CHRNAME_TYRFING","speech","L","CO_101001_08030027")


	--★★子供（女）★★:待って！<br>待ってくれ、まだ……！！
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101001_08030028")

-- ▼直接出力
 --ノワールの首の向き調整
turn_chara(Actor001,-9.596,0.3)
turn_chara(Actor002,104.402,0.3)
keep_ik_lookat(Actor001,Actor002,"J_Head")
set_enable_auto_lookat(Actor002, true)
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ティルフィング？<br>ティルフィング！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --ティルフィングの首の向き調整
CloseTalkWindow()
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:あ…<br>マスター…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030032")

-- ▼直接出力
lookat_delay_weight(Actor002,0.7,0.04,0.5,0.5,0.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Remains")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101001_08030034","CO_101001_08030035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうした？<br>大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:突然ボーッとしだしたから<br>心配したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:ああ、すみません…<br>ご心配をおかけいたしました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか見つけたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030041")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ここに足を踏み入れてから<br>少し様子が変だったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:はい、実は…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030043")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:この壁にかすかに遺る絵に<br>見覚えがあったものですから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たしかに<br>肖像画のようなものが描かれてるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030046")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:顔ははっきりとはしないけど<br>桃色の髪をした女性のような…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:桃色の髪の女性って、ひょっとして！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい。昔の仲間のひとりが描いてくれた<br>私の肖像画です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:本当か！？<br>すごいじゃないか！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030052")

-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:え？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030054")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Smile")

	--★★ノワール★★:まさか本当に<br>昔の仲間につながるものが見つかるなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030055")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ある意味<br>聖杯の手がかりより貴重なものかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ティルフィング★★:そ、そこまでは、さすがに…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030057")


	--★★ノワール★★:どうにかして持って帰れないかな、これ<br>せっかく見つけたんだしさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030059")

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:あの、マスター？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:なぜそのように<br>嬉しそうにされているんですか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030062")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？<br>なんでって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030063")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:この肖像画は<br>かつてのキミの仲間が描いたものなんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030064")


	--★★ノワール★★:これがこうして遺っていたってことは<br>他にもまだあるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030065")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:記録や記憶がなかったとしても、<br>すべてが失われたわけじゃなかったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030066")


	--★★ティルフィング★★:マスター…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それに俺、思うんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030068")


	--★★ノワール★★:かつてキミやキミの仲間たちが<br>バルバロイを封じてくれたから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030069")


	--★★ノワール★★:こうして世界は続いてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:今俺たちが生きているのは<br>キミたちのおかげなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030071")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:それってつまり<br>俺たちこそがキミの仲間が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030072")


	--★★ノワール★★:生きていた証ってことに<br>なるんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030073")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:…そうかも、しれません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030074")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:だろ？<br>だから顔を上げて、胸を張って欲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030075")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:キミは間違いなく世界を<br>そして仲間を救ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030076")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:はい、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030078")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:さーて、ティルフィングの思い出の品が<br>見つかっただけで大収穫な気はするけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030080")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:アーサーからの依頼も<br>ちゃんとやっておかないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030081")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:そうですね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030082")


	--★★ノワール★★:それでさ。あとでその絵の話<br>詳しく聞かせてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030084")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:…もちろん、今、語れるだけで構わないからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_08030085")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:はい！
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_08030087")

-- ▼直接出力
local trustParam = set_communication_rankup("ティルフィング_コミュランク", "ティルフィング_親密度")
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
 load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("BGM_ADV_HolyGrail")
preload_sound("BGM_ADV_Remains")
	InitializeLoad_Preload()
	load_duel_scene_preload(101030011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101001","002","101001002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
