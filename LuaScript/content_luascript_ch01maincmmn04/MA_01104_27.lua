-- このluaスクリプトは、MA_01104_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
set_pos(Actor005, {0.292, 0, 0.74})
set_pos(Actor004, {-0.273, 0, 2.426})
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor001,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115150)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ディナタン★★:………おかえりなさい、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270002")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:…ただいま。ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270003")

	open_select_window_tag(Actor001,"Normal","MA_01104_270004","MA_01104_270005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:心配かけて、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270007")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さんが無事なら、いいよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270008")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:離れ離れは<br>もういやだよ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ここは？<br>…みんなは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270011")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:…キャメロット学園の療養院だよ<br>みんなも無事
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか<br>良かった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270013")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…陰口とか、言われてないか<br>俺がいなかったあいだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270015")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:へっちゃらだよ<br>兄さんがいてくれれば、どこに行っても
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270016")

	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:………ナイスな兄貴じゃねーの
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_270017")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:はい、ナイスな兄さんです
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:…そんじゃあ<br>連れて帰って来て正解だったわけだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_270020")

	open_select_window_tag(Actor001,"Normal","MA_01104_270021","MA_01104_270022")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…ありがとう、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270024")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:キミがギネヴィアたちを<br>守ってくれたんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270025")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:礼を言われる筋合いねーよ<br>誤解されちゃ困るね
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_270026")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:恩着せがましいなあ<br>わざわざ来るなんてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270028")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:お前…冗談だったら笑えねーぞ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_270029")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:ちょっと兄さん！<br>変なこと言わないでよ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270030")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
character_in_move_walk(Actor004,CharaPos004,1.8,0)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:あら。こんにちは
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_270032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
turn_chara(Actor003,184,0.5)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:こんにちはっす！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_270033")


	--★★モルガン★★:ガウェインくんがあなたをおんぶして<br>連れて来てくれたのよ、知ってた～？
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_270034")

	change_face(Actor003,"Smile")

	--★★ガウェイン★★:俺は当然のことをしたまでですよ！<br>モルガン先生！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_270035")

-- ▼直接出力
--モルガン,CHRNAME_MORGAN @名前変更
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★モルガン★★:ガウェインくんは優しいのね～
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270036")

-- ▼直接出力
OpenFirstAppearance(Actor004)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:それに…置いてくわけにも、いかねーからな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_270037")

	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:………アーサー様のノリに<br>乗ってくれてサンキュー
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_270039")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED + FADE_TIME)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:家族団らんを見てるのが一番心休まるわね<br>刺激的じゃない日々がスキよ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270041")

	open_select_window_tag(Actor001,"Normal","MA_01104_270042","MA_01104_270043","MA_01104_270044")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	elseif is_select(3) then
		goto Block3_3
	end

::Block3_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンはずっとここに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270046")

	change_face(Actor004,"Normal")

	--★★モルガン★★:貴方が連れ込まれて<br>目を覚ますまで、ずぅーっとね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270047")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:ずぅーっと、ね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270048")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	goto Block3end

::Block3_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…ゆっくり団らん出来るようになりたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270050")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:うん…、その時は前みたいに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270051")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:…私も力添えするわ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270052")

	goto Block3end

::Block3_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:家族を捨てて刺激的な人生を歩みたいです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270054")

	change_face(Actor004,"Smile")

	--★★モルガン★★:あらあらそれはそれで
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270055")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:ええー！？兄さん、ひどい…！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270056")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:じょ、冗談だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_270057")

	change_face(Actor002,"Anger")

	--★★ディナタン★★:わかってます！！<br>ひどい冗談！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270058")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	goto Block3end

::Block3end::
	change_face(Actor004,"Normal")

	--★★モルガン★★:私はモルガン<br>この療養院の養護教諭よ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270060")

	change_face(Actor004,"Smile")

	--★★モルガン★★:こう見えてアーサー王様の義姉サンなのよ<br>すごいでしょぉ～♪
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
character_in_move_walk(Actor005,CharaPos006,1.8,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0.5,0.5,0.5)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",0.5)
-- ▲直接出力

	--★★マルディサント★★:だりぃ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01104_270063")

	change_face(Actor004,"Normal")

	--★★モルガン★★:あら、どこ行ってたの<br>安静にしてなきゃ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★マルディサント★★:…モルガンせんせ、さ<br>いい加減、授業行けって言わないワケ？
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01104_270065")

	change_face(Actor004,"Smile")

	--★★モルガン★★:…ふふふ～♪<br>ダルいんでしょ？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270066")

	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★マルディサント★★:ハハッ、アタシさぁ<br>モルガンせんせ大ッ好き
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01104_270067")


	--★★モルガン★★:うふふ。私も～
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01104_270068")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
lookat_weight(Actor005,1.0,0.5,0.5,0.5)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マルディサント★★:…ォイ。ナニ見てンだよ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01104_270070")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あ、えっ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270071")


	--★★マルディサント★★:見せモンじゃねェぞ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01104_270072")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:ご、ごめんなさい<br>えへへへへ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270073")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
lookat_delay_weight_reset(Actor002,0.6)
-- ▲直接出力

	--★★マルディサント★★:…気持ち悪ィ笑いかた
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01104_270074")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:えっ、ええっ…！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_270075")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Anger")

	--★★マルディサント★★:ブッてんじゃねえぞ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01104_270076")

-- ▼直接出力
 reserve_next_script("1章/メイン/x0409_戦果報告～認められる立場")
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
	load_area_scene_preload(115150)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
