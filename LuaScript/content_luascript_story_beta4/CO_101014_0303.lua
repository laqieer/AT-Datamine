-- このluaスクリプトは、CO_101014_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",15,CharaPos110061_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_004)
	Camera002 = SetTemplate("Actor002",-110,CharaPos110061_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_005)
	Camera003 = SetTemplate("Actor003",100,CharaPos110061_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_001)
	Camera004 = SetTemplate("Actor004",80,CharaPos110061_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_002)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001, "J_Head")
keep_ik_lookat(Actor001,Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
load_image("103050140", "content_still_10305014_image", "103050140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:最後は…この棚か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:よし、片付け終わりっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:本の返却、終わった？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、終わったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力

	--★★トリスタン★★:そう<br>じゃあこれで解散ってことで
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030007")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなつれないこと言うなよ<br>どうせなら一緒に寮まで…ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030008")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:う～ん、ないなぁ<br>どうしよう
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101014_03030010")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("女子1", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:クリスさんもディンドランさんも<br>ふたりそろって留守だしなあ…
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101014_03030011")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの子たち、なにか困ってるみたいだな<br>行ってみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:本気？<br>お節介にもほどがあるよ、キミ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030014")


	--★★ノワール★★:お節介かどうかは<br>聞いてみなきゃわかんないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030015")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ほら、トリスタンも行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★トリスタン★★:ちょっと！<br>ボクを巻き込まないでほしいんだけど…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030017")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor003)
Appear(Actor004)
turn_lookat(Actor002,Actor003,0)
turn_lookat(Actor001,Actor003,0)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME) 
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:どうかしたのか？<br>困ってるみたいだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030019")

-- ▼直接出力
PlayPartVoice("女子2", "肯定3")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:あっノワールくん！<br>トリスタンくんも！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101014_03030020")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:ビックリした～！<br>君たちも大図書院来てたんだ
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101014_03030021")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、まあ…<br>ちょっと課題をやりにな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030022")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:それは今関係ないでしょ<br>そっちこそなにしてるの？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030023")

-- ▼直接出力
PlayPartVoice("女子2", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:魔獣学の授業の参考用に本を探してるの<br>『ドラゴンと人の交わり』っていうんだけど
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101014_03030024")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:『ドラゴンと人の交わり』？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030025")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:大昔ね<br>人間は巨大なドラゴンと共存していたんだって
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101014_03030026")


	--★★キャメロット騎士学術院（女）②★★:そのことについて記された本なの
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101014_03030027")


	--★★キャメロット騎士学術院（女）③★★:山ほどの大きさのドラゴンなんて<br>ホントにいたのかしらね～？
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101014_03030028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ブレイズ先生が自慢してた気がする<br>「前に巨大なドラゴンと戦ったことがある」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030029")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("女子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:ウッソだぁ～！<br>ぜったい盛ってるよ～！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101014_03030030")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:「人からの畏怖の念が少なくなるにつれ<br>ドラゴンの体は小さくなっていった」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030031")


	--★★ノワール★★:「しかし、わずかじゃが、まだ世界のどこかには<br> 大きな体と高い知能をもつ竜が生きておる」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…とも言ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030033")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1", "喜び")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:はい、ウソ確定～<br>高い知能をもったドラゴンなんていません～
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101014_03030034")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:あのさ。脱線はそのへんにしておこうよ<br>魔獣についての本の棚にはなかったんでしょ？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:じゃあ、民俗学について書かれた本の棚は？<br>それらしき記述があるかもしれないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030036")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("女子2","0028")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:民俗学？
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101014_03030037")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力

	--★★トリスタン★★:本当に巨大なドラゴンが存在していたのなら<br>生活や文化にも影響を及ぼしてるんじゃないかな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030038")


	--★★トリスタン★★:あとは、本が貸出中だったとも考えられるね<br>返却棚を見てみたら？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030039")

-- ▼直接出力
PlayPartVoice("女子1", "納得")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:なるほど～、そっちのセンは考えてなかった！<br>ねえ、行ってみようよ！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101014_03030040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子2", "喜び")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:賛成！トリスタンくん、ありがとうね<br>ノワールくんも！
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101014_03030041")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Hide(Actor004)
turn_lookat(Actor002,Actor001,0)
turn_lookat(Actor001,Actor002,0)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なんとかなるかな<br>うまくいくといいよな、トリスタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030043")

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:別に、ボクには関係ないし
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030044")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:とかなんとか言って<br>さらっとアドバイスしてたじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030045")


	--★★ノワール★★:そういえば、さっきは俺にも<br>詩の作りかたのアドバイスをしてくれたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030046")

-- ▼直接出力
CloseTalkWindow() 
wait_time(0.2)
show_image("103050140", 0.0, 0.0, 0.2 ,true,false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
wait_time(1)
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_03030047")

-- ▼直接出力
setup_small_camera_end()
CloseTalkWindow()
hide_image(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
wait_time(0.5)
PlayPartVoice("トリスタン", "否定")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★トリスタン★★:しつこいな<br>嫌いだって言ったでしょ、握手
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030049")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:まあ、彼女たちの勉強がはかどるといいね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_03030051")

-- ▼直接出力
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
load_image_preload("103050140", "content_still_10305014_image", "103050140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
