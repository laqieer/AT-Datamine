-- このluaスクリプトは、CO_101039_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor005,"J_Head")
lookat_weight(Actor004,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
keep_ik_lookat(Actor005,Actor004,"J_Head")
lookat_weight(Actor005,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
keep_ik_lookat(Actor006,Actor005,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
keep_ik_lookat(Actor007,Actor005,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor004,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:おおっ、フレンとノワール！<br>ちょうどいいところに来てくれた！
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_08030002")

	change_face(Actor002,"Surprise")

	--★★フレン★★:どうしたの？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:部内の対立がヒートアップしすぎて<br>もう俺では止められなくなってしまった
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_08030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:「もう陸上部をやめる！」<br>と言い出す生徒すらいる
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_08030005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだって！？<br>ずっと同じ部活で頑張ってきた仲間だろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08030006")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.8)
wait_time(0.1)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:だいたい、ローマはいつまで<br>この島を自分たちの領土だと思っているんだ！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_08030008")


	--★★キャメロット騎士学術院（男）★★:バルバロイに覆い尽くされるからと<br>尻尾を巻いて出て行ったくせに
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_08030009")


	--★★キャメロット騎士学術院（男）★★:ロンディニウムがあるから所有権を求めるのか？<br>やりかたが小賢しいんだよ！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_08030010")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "怒り")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ジーン部長もなんか言ってやってくれ！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_08030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:あー、いや…ログレスの今は<br>ローマの協力あっての部分もあるしだな…
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_08030012")

	PlayAction(Actor005,"to  Std_Surp")

	--★★キャメロット騎士学術院（男）②★★:そうだ！今いる貴族たちも<br>かつてのローマの助力があっての身分だろう
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030013")


	--★★キャメロット騎士学術院（男）②★★:そもそも<br>島の所有権にこだわっているのはログレスだ
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ログレス貴族たちを次々と<br>ロンディニウムに住まわせ
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030015")

	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("現代男子", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:自治権を奪おうとしているらしいじゃないか！
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030016")

-- ▼直接出力
se_play("SE_ADV_MA_01C110_42_Crowd")
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("現代男子", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ノワールも思うところがあるだろう！？
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_08030020","CO_101039_08030021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おいおい<br>こんなことでケンカは良くないって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08030023")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("現代男子", "怒り")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★キャメロット騎士学術院（男）②★★:はっきりした意見をもっていないなら<br>しゃしゃり出てくるな！
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030024")

-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★キャメロット騎士学術院（男）★★:だいたいお前は陸上部員じゃないだろ！<br>部外者は黙ってろ！
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_08030025")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（巻き込んだのはそっちだろう…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101039_08030026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:お前ら、いい加減にしろ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08030028")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:みんなで楽しく運動する<br>それが陸上部のモットーだろ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08030029")

	change_face(Actor001,"Anger")

	--★★ノワール★★:それに競技ってのは<br>どの国が正しいかを決めるものじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08030030")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★ノワール★★:どこまで自分を鍛え上げることができたのか<br>その結果を競うものだろう！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08030031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:そうだよ、ノワールくんの言うとおり！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030032")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★フレン★★:今日はね<br>みんなに伝えたいことがあるんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030034")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★キャメロット騎士学術院（男）★★:伝えたいこと？
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_08030035")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:以前計画がとん挫した競技大会を<br>開催できるかもしれないんだ
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_08030037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:おおっ！？
	Talk(Actor006,"NPCNAME_0285","speech","L","CO_101039_08030038")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:しかも<br>成績優秀者には豪華賞品も出るそうだ！
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_08030039")


	--★★キャメロット騎士学術院（女）②★★:おおおお～っ！！
	Talk(Actor006,"NPCNAME_0285","speech","L","CO_101039_08030040")


	--★★フレン★★:でもね<br>ひとつ条件があるの
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030041")

	change_face(Actor005,"Normal")

	--★★キャメロット騎士学術院（男）②★★:条件だって？
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030042")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:陸上部のみんなが仲良くなること<br>それができないと、大会は開催してもらえない
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★フレン★★:だから…ね、ふたりとも？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030045")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）★★:無理だ<br>こいつらと仲良くなんてできない
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_08030046")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:どうして！？<br>前はみんな仲良くやってたでしょ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:それはそれ<br>これはこれだよ
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030048")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力

	--★★フレン★★:他の陸上部のみんなのためにも<br>仲直りしてよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030049")


	--★★キャメロット騎士学術院（男）★★:…じゃあ、俺たち陸上部を辞めるよ<br>ローマの連中で仲良く大会やればいい
	Talk(Actor004,"NPCNAME_0266","speech","L","CO_101039_08030051")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor004,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）②★★:お前らばっかりいい恰好すんな<br>それならこっちも辞める
	Talk(Actor005,"NPCNAME_0265","speech","L","CO_101039_08030052")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ちょっと待てみんな！
	Talk(Actor003,"NPCNAME_0241","speech","L","CO_101039_08030054")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("フレン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ど、どうしたらいいの…？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08030055")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ8_4")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
