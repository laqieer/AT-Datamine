-- このluaスクリプトは、EA_007_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110091_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_006)
	Camera006 = SetTemplate("Actor007",nil,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{-2.2, 0, 3.25})
set_pos(Actor004,{5.68, 0, 1.23})
set_pos(Actor005,{5.86, 0, 0.3,   281})
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor001,Actor002,0.4)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0.4)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101013","001","101013001")
	Actor007 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★クラリス★★:ちょっとだけビンカンでして～わたし
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210004")


	--★★クラリス★★:カンがするどいと言いますか～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0009")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:「たぶんこうなるかもしれないかも？」<br>というのがわかるかもしれないと言いますか～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:えーと？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★クラリス★★:そういうことなんです
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210008")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:ううーんと？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210009")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リアム","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リアム★★:「クラリスの予感は時々当たる」<br>ということでしょう
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210010")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0014")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:詳しくお話するのは難しいんですよね～<br>整理できましたら、いずれ
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210011")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:…予感した結果が──『視える』？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★クラリス★★:わたし、目が悪いからか<br>ぼんやりとですが
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210014")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Laugh")

	--★★クラリス★★:だから杞憂に終わることのほうが多いんです<br>ドキドキです～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210015")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:あの──カイルという少年に起こる<br>不幸を『視た』ってことか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リアム","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★リアム★★:はい…あり得ない話ではないのです
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210017")


	--★★リアム★★:<ruby=カイルくん>あの子</ruby>のご両親は<br>ロンディニウム随一の大商人です
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210018")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★リアム★★:よからぬことを企む者がいないとも限りません<br>例えば…カイルくんを誘拐して──とか
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210020")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:その…ご両親は？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力

	--★★クラリス★★:ご安心を。ご健在ですよ～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210022")

-- ▼直接出力
PlayPartVoiceDirect("リアム","0008")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リアム★★:あのロンディニウムの事件のあと<br>私財を投じて都の復興に力を尽くしています
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210023")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★リアム★★:しかしそれゆえ<br>ご両親は多忙を極め──
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210025")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor007)
PlayActionDirect(Actor007,"to Wlk")
turn_lookat_position(Actor007,CharaPos110091_01_002[1],CharaPos110091_01_002[2],CharaPos110091_01_002[3],0)
slidemove(Actor007,CharaPos110091_01_002[1],CharaPos110091_01_002[2],CharaPos110091_01_002[3],1.8)
wait_time(0.2)
setup_small_camera_start()
wait_time(1.6)
PlayActionDirect(Actor007,"to Std_Loop")
turn_chara(Actor007,CharaPos110091_01_002[4],0.3)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")

	--★★カイル★★:「今年の降誕祭は一緒にいられないかも」<br>って言うんだよ！
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210028")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor007,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor007,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor007,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★クラリス★★:あら～カイルくん<br>お食事はもういいんですか～？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210029")

-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0007")
-- ▲直接出力

	--★★カイル★★:
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★クラリス★★:おそまつさまでした～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210031")

	PlayAction(Actor007,"to  Std_No")

	--★★カイル★★:話戻すけど！ボクだって大商人の息子だ<br>親が忙しいのはイイことだってわかってる
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210032")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★カイル★★:だから今年の降誕祭はボクが<br>ママやパパに幸せを贈ってあげたいんだ
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:それが、サプライズプレゼントか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210034")


	--★★カイル★★:親がよく「商売はツキを掴むべし」って言うんだ<br>だから…なにか幸運になるようなモノをさ──
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210035")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)

	--★★カイル★★:ないよ！<br>贈り物が決まるまではね！
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210038")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★リアム★★:うーん、しかし…<br>叔父様も心配しているでしょう
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210039")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210040")

	PlayAction(Actor007,"to  Std_Talk")

	--★★カイル★★:ボクの叔父さんにね<br>サプライズプレゼントのこと相談したんだ
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210041")

	change_face(Actor001,"Normal")

	--★★クラリス★★:叔父様も、カイルくんのご両親と同じく<br>ロンディニウムの商人さんらしくて～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★クラリス★★:その叔父様ならプレゼントに適したものを<br>取り扱っているのではないかと踏んだんですね～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0034")
-- ▲直接出力

	--★★カイル★★:でもママとパパが取り扱ってる物のほうが<br>はるかに上等でさ、まいっちゃったよ
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210044")


	--★★カイル★★:そうしたら叔父さんが「ロンディニウムの外なら<br>珍しい品物もあるかも」って言ってさ
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210045")

	PlayAction(Actor007,"to  Std_Talk")

	--★★カイル★★:
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★カイル★★:でも叔父さんにプレゼントの内容が知られたら<br>ママとかパパにも漏らしちゃうかもしれないだろ
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210047")


	--★★カイル★★:だからログレスに着いてすぐ<br>叔父さんに黙ってひとりで街に繰り出したら──
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210048")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210049")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ノワール★★:あれ、じゃあ…今、叔父さんから見たら<br>カイルくんは行方不明…ってことに？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210050")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0033")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:はい、恐らく…
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0210051")

-- ▼直接出力
set_common_look_at(Actor003,Actor002)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★リアム★★:ですので、カイルくんの叔父様については<br>わたしたちのほうでも探させています
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リアム","0025")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リアム★★:しかし商人が出入りする下町も含めると<br>城下町も広いですからね…
	Talk(Actor003,"CHRNAME_LIAM","speech","L","EA_007_0210053")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0040")
-- ▲直接出力

	--★★カイル★★:プレゼントが決まるまでは<br>叔父さん見つけなくていいよ！
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210054")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力

	--★★ガウェイン2★★:
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","EA_007_0210056")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_start()
Appear(Actor005)
Appear(Actor004)
wait_time(0.4)
character_in_move_walk(Actor004,CharaPos008,2.0,0.25)
character_in_move_walk(Actor005,CharaPos006,2.0,0.25)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor005,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor005,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor005,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ラグネル★★:早く帰してあげないと叔父様も可哀想だし<br>そっこーでプレゼント決めちゃおう！
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_007_0210058")


	--★★カイル★★:
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210059")

	PlayAction(Actor007,"to  Std_Talk")

	--★★カイル★★:
	Talk(Actor007,"NPCNAME_0386","speech","L","EA_007_0210060")

	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Surprise")

	--★★ラグネル★★:
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_007_0210061")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0210062")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0210064")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0033")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ラグネル★★:
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_007_0210066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★ラグネル★★:
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_007_0210067")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101013","001","101013001")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
