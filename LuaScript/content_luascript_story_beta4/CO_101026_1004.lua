-- このluaスクリプトは、CO_101026_1004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_delay_weight(Actor001, 1.0,0.08,0.4,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight(Actor002, 0.8,0,0.4,0.35,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:義姉さんが引き続き<br>妖精の森に集まる記憶について調べてくれてる
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ひょっとしたら近々<br>記憶を取り戻す方法が見つかるかもしれないね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あの森に行くなら手伝うよ<br>俺にも声をかけてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10040005")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:もとよりそのつもりさ<br>イヤだといっても付き合わせるよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040006")

-- ▼直接出力
wait_time(0.8)
lookat_delay_weight_reset(Actor002 , 0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,201,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:ジャンが存在したという記憶が<br>完全になくなったわけじゃない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040008")


	--★★パーシヴァル★★:ボクやダニー、義姉さん
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040009")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:それにキミをはじめとした学園のみんなも<br>ジャンのことを覚えていてくれている
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★パーシヴァル★★:だから<br>これから作っていけばいいと思うんだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:古い記憶に負けない<br>新しい記憶をね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040012")

	open_select_window_tag(Actor001,"Normal","CO_101026_10040014","CO_101026_10040015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ジャンとの思い出作り<br>俺にも協力させてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10040017")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,117,0.5)
wait_time(0.5)
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight(Actor002, 0.8,0,0.4,0.35,1)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:おいおい、さっきも言っただろう？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:もとよりそのつもりさ<br>イヤだといっても付き合わせるよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それもノブリス・オブリージュの一環か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10040021")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,117,0.5)
wait_time(0.5)
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookat_delay_weight(Actor002, 0.8,0,0.4,0.35,1)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:キミも貴族とはどうあるべきかが<br>わかってきたようだね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:付き人をやらせた甲斐があるよ<br>ボクとしても鼻が高い！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040023")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:…もっとも今回のは少し違うけれどね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040024")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10040025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:なんでもない<br>こっちのことさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040026")

	goto Block1end

::Block1end::
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:そろそろキミを付き人から外そうと思う<br>十分、貴族について理解したようだからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★パーシヴァル★★:これからも精進したまえ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？あ、ああ…<br>ありがとう、と言えばいいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10040030")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力

	--★★パーシヴァル★★:いや<br>礼を言うのはボクのほうだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:ダニーやジャン、義姉さんの件では<br>その…ありがとう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040033")


	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10040035")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:な、なんだいその顔は！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いやあ、パーシヴァルから<br>そんな言葉が聞けるとは思ってなかったからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10040037")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:失敬な庶民だなキミは！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040038")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力

	--★★ノワール★★:お礼なんていらないよ<br>俺たち、友達だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10040040")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:…友達だって？<br>ボクが？キミと？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040041")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:友達…友達か<br>そんな関係も悪くないか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040043")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:では、これからもよろしく頼むよ<br>同じ円卓の騎士として。そして友達としてね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10040044")

-- ▼直接出力
local trustParam = set_communication_rankup("パーシヴァル_コミュランク", "パーシヴァル_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
