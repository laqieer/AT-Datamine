-- このluaスクリプトは、MA_01A112_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-90,CharaPos110061_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
prop001=setup_prop_object(10106004)
prop001_offset={-0.14,-0.02,0.02,160,0,0}
on_parent(prop001,Actor002, "J_Hand_L", prop001_offset)
on_active(prop001)
Hide(Actor001)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_camera_nearclip(Camera003,1)
set_common_look_at(Actor003,Actor005)
set_common_look_at(Actor004,Actor005)
lookat_weight(Actor004,0.7,0.03,0.7,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:本の返却なら受け付けましょうか？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","MA_01A112_050002")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("エクセリア", "否定")
-- ▲直接出力

	--★★エクセリア★★:ディンドランが療養中でご不在というならいいわ<br>少し感想を述べたかっただけだから
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor001)
Appear(Actor002)
PlayActionDirect(Actor002,"to LookFor")
set_rot(Actor005,{0,150,0})
 --PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リリアーナ★★:お、お大事にと、お伝えください…
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050004")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera004)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Show")
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",0.5)
wait_time(0.3)
-- ▲直接出力

	--★★エクセリア★★:なにかしら
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050006")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あの…<br>これ、受け取って、ください
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050008")


	--★★エクセリア★★:…手紙？<br>なんの真似かしら
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050009")


	--★★ギネヴィア★★:あ、う…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050010")

	open_select_window_tag(Actor001,"Normal","MA_01A112_050012","MA_01A112_050013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor003,{0,75,0})
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ガラハッドのことだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_050015")

-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:………わたしが剣を、彼女に向けて…だから──
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050016")

-- ▼直接出力
 --PlayPartVoice("エクセリア", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★エクセリア★★:あれは銀卓の子よ<br>あなたたちが気にすること？
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
set_rot(Actor003,{0,75,0})
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お見舞いの手紙だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_050019")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
 --PlayPartVoice("エクセリア", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★エクセリア★★:私たちはキラーズ…見舞いなど不要よ<br>戦うためにある。銀卓の矜持と共にある
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050020")

-- ▼直接出力
 --PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リリアーナ★★:…戦いへの復帰は、まだできないけど<br>ご心配はいただかなくても、なんとかしますから
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050021")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あの…ううん、その──
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050022")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★エクセリア★★:………ごめんなさい<br>本当は誰に宛てたものか、わかっているわ
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050023")

	goto Block1end

::Block1end::
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あやまり、たいの…でも
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050025")


	--★★ギネヴィア★★:こ、こ、言葉が出ないの、でも伝えなきゃって…<br>紙に、書いてきたから…これ、これを…っ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050026")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★リリアーナ★★:お受け取りできません
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050028")

	change_face(Actor001,"Sad")

	--★★ノワール★★:どうして…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_050029")

-- ▼直接出力
setup_small_camera_start(Camera003)
off_parent(prop001)
off_active(prop001)
PlayActionDirect(Actor002,"to Std_Loop")
 --PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:ガラハッドは責務を果たしたからです
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050030")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★エクセリア★★:あのとき、スノードンの山頂で<br>私たちが聖杯を見つけたとき…
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050032")


	--★★エクセリア★★:先に聖杯へ手を伸ばしたのは<br>ランスロット卿だったわ
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050033")


	--★★エクセリア★★:聖杯自体、得体の知れない遺物<br>その力が及ぼす影響は想像もつかない
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050034")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("リリアーナ", "肯定2")
-- ▲直接出力

	--★★リリアーナ★★:でも誰かが聖杯を手にしなければならなかった<br>聖杯を持ち帰らなければ戦いは終わらない…
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050035")

	PlayAction(Actor004,"to  Std_Talk")

	--★★エクセリア★★:触れた者になにが起きるのか…わからないまま<br>ランスロット卿は身を挺そうと考えた、けど──
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050036")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★リリアーナ★★:ガラハッドは聖杯が放つ不穏な光を感じ取ってか<br>ランスロット卿をかばって聖杯に触れました
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050037")

-- ▼直接出力
 --PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★エクセリア★★:本来であれば彼女に引導を渡すのは<br>我ら銀卓騎士団のはずだったわ
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:………ガラハッドは<br>強かったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_050040")

-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★エクセリア★★:ガラハッドはランスロット卿を守り切った<br>立派よ。銀卓の矜持を全うした
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050041")


	--★★リリアーナ★★:おふたりも継承者としての務めを果たそうとし<br>ローマを退け障害を取り除きました。立派です
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050042")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ギネヴィア★★:…ごめんなさい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★リリアーナ★★:詫びなければならないのはこちらです
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050044")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:貴方は貴方のなすべきことをしたわ<br>だから手紙も、詫びの言葉も受け取れない
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050045")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力

	--★★ギネヴィア★★:ごめんなさい…、ご、ごめんなさい…っ<br>わたし、周りがぜんぜん見えなく、なっていて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050047")


	--★★ギネヴィア★★:ただ、ただ必死に…剣をガラハッドへ──<br>振り下ろし…て、こんな、わたし…っ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050048")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★ギネヴィア★★:自分が楽になろうとしてばかり──…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050049")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エクセリア", "否定")
-- ▲直接出力

	--★★エクセリア★★:…いいのよ。継承者の劔に課せられる責務は<br>我らの比ではない
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","MA_01A112_050051")

-- ▼直接出力
 --PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:投げ出せるような人でもないことは<br>あの日の演説でわかりましたから、今は…楽に
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01A112_050053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start(Camera002)
lookat_weight(Actor001,0.8,0.03,0.7,0)
 --PlayPartVoice("ギネヴィア", "苦しみ")
-- ▲直接出力

	--★★ギネヴィア★★:ごめんなさい、ごめんなさい…ありがとう<br>わたし…もっと、がんばるから、ごめんなさい…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050054")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:わかんないの、もうどうしたらいいか…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050055")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:これまでやってきたことを無駄にしないように<br>これからのために戦ってるのに…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050056")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力

	--★★ギネヴィア★★:これまでのことなんて忘れちゃって<br>これからどうしたらいいかわからなくて…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:でも、がんばるから<br>わたし、がんばるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050058")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:よわくても、まけたくないから──…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_050059")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106004)
prop001_offset={-0.14,-0.02,0.02,160,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
