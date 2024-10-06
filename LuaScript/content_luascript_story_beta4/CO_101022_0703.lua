-- このluaスクリプトは、CO_101022_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
lookat_weight(Actor004,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:あの、ちょっと聞きたいことがあるんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030002")

-- ▼直接出力
PlayPartVoice("女子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:え？なに？
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:アーサー王が実はログレスや円卓を憎んでたなんてウワサ、聞いたことあるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("女子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:え！？なにそれ！意味わかんないんだけど
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030005")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:え？あんた知らないの？<br>今けっこーウワサになってるよ
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030006")


	--★★キャメロット騎士学術院（女）②★★:アーサー様はもともと学園が嫌いで
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030007")

	PlayAction(Actor004,"to  Std_Talk")

	--★★キャメロット騎士学術院（女）②★★:ああやって裏切るためにずーっと準備してたんだって
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030008")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("女子1", "怒り")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:な、な、なにそれ！信じらんない！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030009")


	--★★キャメロット騎士学術院（女）★★:アーサー様がそんなことするわけないじゃん！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("女子2", "否定")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:あたしだって本気で信じてるわけじゃないけど…でも、実際アーサー様いなくなっちゃったし
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030011")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子1", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:そ、それはそうだけどさあ…
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030012")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:えーっと、いいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030013")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:できればそのウワサの出所を教えて欲しいんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030014")

-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:え？どこだったっけなぁ
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030015")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:ねえ、調査してるって言ってたよね？キミひとりでやってるの？
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？いやモルドレッドとふたりでやってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030018")

	PlayAction(Actor003,"to  Std_Surp")

	--★★キャメロット騎士学術院（女）★★:え？モルドレッドさんと？
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030019")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:なんか変か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:変っていうか…
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030022")


	--★★キャメロット騎士学術院（女）★★:モルドレッドさんって、アーサー様のこと嫌ってたでしょ？なのになんでかなって
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030023")


	--★★キャメロット騎士学術院（女）★★:アーサー様の悪いウワサがあっても別に気にする必要はないっていうか
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:なんだったら新しく王様になるつもりなのかなって
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_07030027","CO_101022_07030028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:あいつをアーサーの代わりみたいに言うなよ失礼だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030030")

	change_face(Actor003,"Normal")

	--★★キャメロット騎士学術院（女）★★:ご、ごめん…
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030031")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな簡単に王になんか…なれるわけない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:あいつの気持ちも考えろよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030034")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:モルドレッドだって円卓の騎士でアーサーに…裏切られたひとりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030035")

	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Normal")

	--★★キャメロット騎士学術院（女）★★:そ、そうだよねごめん…
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030036")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:モルドレッドもアーサーもきっとずっと大変な思いをしてきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030038")

	change_face(Actor001,"Sad")

	--★★ノワール★★:なんで道を違えることになっちゃったのかまだわからないけれど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:少なくとも外野が好き勝手言っていいようなことじゃないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030040")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子1", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★キャメロット騎士学術院（女）★★:うう、反省します…
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030041")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor002,Camera002,EntryData110191_01_08,CameraAssetBundleName110191_01,CameraPos110191_01_108)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_delay_weight(Actor002,0.5,0.05,0.8,0.2,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_delay_weight(Actor001,0.7,0.2,0.5,0.2,1.0)
set_enable_auto_lookat(Actor003, true)
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:おい、そっちの調査はどうだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07030043")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("女子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:え！？モ、モルドレッドさん！？
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030044")


	--★★モルドレッド★★:あ？なんだおめえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07030046")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")

	--★★キャメロット騎士学術院（女）★★:い、いや、その…
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030047")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子2", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:あ！思い出した！！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:えっとねー、剣術部の子！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030051")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030052")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:あたしにあの噂を教えてくれた子が言ってたその子は剣術部の子から聞いたんだって
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:剣術部かありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030055")

	PlayAction(Actor004,"to Greet_one")

	--★★キャメロット騎士学術院（女）②★★:いやー、思い出せてよかったよかったそれじゃあね～！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101022_07030056")

	PlayAction(Actor003,"to Greet_one")

	--★★キャメロット騎士学術院（女）★★:ば、ばいばい…
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101022_07030057")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
Hide(Actor004)
turn_chara(Actor001,-29.449,0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.05,0.8,0.2)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:剣術部だって情報が得られてよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030059")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:ああ…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07030060")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…モルドレッド？どうかしたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030061")


	--★★モルドレッド★★:あー…おい、その…なんだ…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07030063")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:らしくないな言いたいことあればはっきり言えよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030064")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:うるせえな！今日はこれ以上調査を続ける気分じゃねえんだよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07030065")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:話を聞きに行くのはまたあとですんぞ！わかったな！？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07030066")

-- ▼直接出力
 setup_small_camera_start(Camera002)
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor002,"to Wlk")
wait_time(2.0)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor002)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なに怒ってんだ、あいつ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07030068")

-- ▼直接出力
local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")
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
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
