-- このluaスクリプトは、CO_101061_0302.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:はー、食った食った
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020002")


	--★★ノワール★★:（ちゃんと年相応の表情もできるんだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101061_03020003")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:なに？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020005")

	open_select_window_tag(Actor001,"Normal","CO_101061_03020007","CO_101061_03020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:美味しい料理だったなと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:でしょ？<br>仲間たちにも評判なんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020011")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:他にオススメの店見つけたら<br>紹介してあげるよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:笑顔がかわいいなって思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:は？オレ、男だよ<br>かわいいとか言われても嬉しくないから
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わ、悪かったよ<br>別にそこまで怒らなくていいだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020016")

-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:アンタが変なこと言うからでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020017")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:それより、アンタのお陰で<br>勉強が捗ってるよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020019")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺のお陰？<br>勉強？？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラロゥ★★:学園の授業を窓の外で聞いてるんだ<br>本に載ってないことばかりで面白いよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020021")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:最近のお気に入りは考古学！<br>大昔の遺跡とか財宝の話ってワクワクするよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:あとは外国語の授業もいいね<br>単語の発音がわかるのはタメになる
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020023")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなことしなくても学園に通いたいなら相談してくれればいいのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:通いたいわけじゃないって言ったでしょ<br>ただの知的好奇心だよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020027")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:熱心なのはいいけど<br>くれぐれも問題を起こすなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020028")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:わかってるってば
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020029")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,110,0,0.1)
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,136,0,0.1)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("山賊", "怒り")
-- ▲直接出力

	--★★山賊★★:け、なんだよこの店は
	Talk(Actor003,"NPCNAME_0257","speech","N","CO_101061_03020031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★山賊★★:料理に毛が入ってるっつってんのに<br>きっちり金とりやがって…
	Talk(Actor003,"NPCNAME_0257","speech","N","CO_101061_03020032")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")

	--★★山賊★★:今度は虫でもいれてやるか
	Talk(Actor003,"NPCNAME_0257","speech","N","CO_101061_03020033")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Normal")

	--★★ラロゥ★★:あ、すいません
	Talk(Actor002,"CHRNAME_LAROU","speech","N","CO_101061_03020035")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("山賊", "激怒")
-- ▲直接出力
	close_cutin()

	--★★山賊★★:ガキが…気をつけろ！
	Talk(Actor003,"NPCNAME_0257","speech","N","CO_101061_03020036")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
turn(Actor001,0,154,0,0.1)
turn(Actor002,0,200,0,0.1)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おい、なにをしたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020038")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:財布盗ってやった♪<br>今日はアイツのおごりってことにしよう
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…返してくるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020041")

-- ▼直接出力
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:なんだよ<br>アイツ、オレの馴染みの店に迷惑かけたんだよ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラロゥ★★:このくらい当然だろ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020043")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:どんな理由があっても<br>他人からモノを盗んだらダメだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:な、なに怒ってんの？<br>オレは盗賊だよ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020045")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:盗賊だろうがなんだろうが<br>他人からモノを盗むのはダメなことなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:わかったよ、これはアイツに返してくる<br>あーあ、アンタに貸しのまんまか
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020049")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:…それじゃ、また今度
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03020050")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、またな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03020051")

-- ▼直接出力
local trustParam = set_communication_rankup("ラロゥ_コミュランク", "ラロゥ_親密度")
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
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
