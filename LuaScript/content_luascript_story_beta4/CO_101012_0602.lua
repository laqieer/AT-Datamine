-- このluaスクリプトは、CO_101012_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",30,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	Camera002 = SetTemplate("Actor002",150,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor004,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor004)
force_eyesync(Actor004,"Close")
reserve_eyesync(Actor004,"Close")
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Sing_Side_Bed")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon_D")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…よし。これで全部か<br>ふぅ。意外と疲れたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:ありがとう、兄さん！<br>これでだいぶ整理できましたね、イゾルデさん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020003")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:そうね。支援物資が届いたはいいけど<br>量が多くて困っていたから
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:これで治療に専念できるわ<br>感謝するわね、ノワール
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101012_06020007","CO_101012_06020008","CO_101012_06020009")
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
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:大したことはしてないよ<br>ディナタンが世話になってるからそのお礼だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020011")

	change_face(Actor003,"Normal")

	--★★イゾルデ★★:どちらかというと<br>世話になってるのはこちらのほうよ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020012")

-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★イゾルデ★★:ディナタンがいなければ療養院は回らないもの<br>感謝しているわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:そんな…私なんて全然ですよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:イゾルデに礼を言われるなんてな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020016")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★イゾルデ★★:あら、それはどういう意味かしら<br>私はお前と違って礼節はわきまえているわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020017")

-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さん…ちょっと失礼だよ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ご、ごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:療養院の状況はどうなってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020021")

-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★イゾルデ★★:正直、いいとは言えないわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020022")

	change_face(Actor003,"Sad")

	--★★イゾルデ★★:人手が足りなすぎて<br>患者へのケアが行き届いていない
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020023")

	change_face(Actor003,"Sad")

	--★★イゾルデ★★:それに精神的に不安定な患者が多くて<br>みんなピリピリしているの
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020024")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★イゾルデ★★:まぁ、あんなことがあったのだから<br>しかたないけれど
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020025")

-- ▼直接出力
PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…なにか、できることないかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020026")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:じゃあ、あとは任せていいかしら<br>私は他の患者を診ないといけないから
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:はい！任せてください
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020029")

-- ▼直接出力

 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ベッド、全部埋まってるんだな<br>それだけ被害が大きかったってことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020031")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor002, ノワール, "J_Head")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:うん…これでも一時期よりは<br>だいぶ落ち着いたらしいんだけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020032")

-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力

	--★★ディナタン★★:でも、みんなすごく辛そう<br>…もっと私にできることがあれば
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020033")

-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ううう…！
	Talk(Actor004,"NPCNAME_0225","speech","L","CO_101012_06020035")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…！大丈夫？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020036")

-- ▼直接出力
	set_common_look_at(Actor004,Actor002)
reserve_eyesync(Actor004,"Auto")
PlayPartVoice("男子1", "苦しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:うう…痛い…痛いよ…<br>痛くて、眠れないんだ…
	Talk(Actor004,"NPCNAME_0225","speech","L","CO_101012_06020037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:落ち着いて…そうだ<br>気晴らしになるかわからないけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020038")


	--★★ディナタン★★:…少しでも、あなたの心が安らぎますように
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020039")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Sing_Side_Bed")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
 --ディナタンの歌
wait_time(10.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Noon_D")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:…痛みが、和らいできた気がする
	Talk(Actor004,"NPCNAME_0225","speech","L","CO_101012_06020041")

-- ▼直接出力
setup_small_camera_end()
reserve_eyesync(Actor004,"Close")
lookat_delay_weight_reset(Actor004,0.6)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:よかった。落ち着いたみたい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020043")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あるじゃないか、ディナタン<br>ディナタンにできること
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020044")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor002, ノワール, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:え？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020045")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:歌だよ。昔から、ディナタンの歌を聞くと<br>不思議と元気が湧いてきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020046")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:ブライアンや傭兵団のみんなも言ってただろ<br>ディナタンの歌は万病に効く、ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020047")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★ディナタン★★:そ、そんなのただのお世辞だよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020048")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:そんなことない<br>ギネヴィアだって言ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020049")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:「ディナタンが歌えば<br>きっとみんな元気になるから」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020050")

-- ▼直接出力
 --白背景に移行
CloseTalkWindow() --疑似バトルならclose_speech_window(
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★テロップ★★:ね、お願い。ディナタンが歌えば<br>きっとみんな元気になるから
	Talk(Actor005,"telop","simple","L","CO_101012_06020052")

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow() --疑似バトルなら
setup_small_camera_start()
close_speech_window()
hide_image(BLACK_WHITE_TIME)

-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…できるかな<br>私の歌で、みんなを元気に
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:できるさ。ディナタンになら<br>俺も協力するよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:…うん…！<br>私、やってみる…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020056")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:――ありがとう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020057")

-- ▼直接出力

 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor003)
turn_lookat(Actor002,Actor003,0)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor002, イゾルデ, "J_Head")
turn_chara(Actor001,-50,0)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★イゾルデ★★:患者の心を癒すためにコンサートを催したい<br>…なるほど、話はわかったわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020059")

	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:悪くないのではないかしら<br>みんなの気晴らしにもなると思うわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:いいんですか？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020061")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:ええ。あなたのその患者を慰めたいという思い<br>とても尊いと思う
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020062")


	--★★イゾルデ★★:せっかくだから、その想いを込めて<br>オリジナルの歌を作ってみてはどう？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101012_06020063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力

	--★★ディナタン★★:お、オリジナルの歌！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020064")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いいかもな。そのほうがディナタンの気持ちも<br>まっすぐ伝わるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_06020065")

-- ▼直接出力
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor002, ノワール, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:うう…簡単に言ってくれちゃって<br>でもふたりの言うとおりかもしれないですね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020066")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:よし…私、がんばってみる<br>みんなが元気になれるような歌を作るために?
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_06020067")

-- ▼直接出力
local trustParam = set_communication_rankup("ディナタン_コミュランク", "ディナタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
preload_sound("BGM_ADV_Sing_Side_Bed")
preload_sound("BGM_Area_Noon_D")
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
