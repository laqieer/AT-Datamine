-- このluaスクリプトは、MA_01A111_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111031_01","111031_01_h")
Include("content_adv_advsmall_111031_01","Template111031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111031_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_004)
	InitializeTemplateRandomCamera111031_01()
	InitializeTemplate111031_01()
-- ▼直接出力
Hide(Actor001)
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:お茶には付き合ってくれるのね
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220002")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:あなたのいれたお茶が好きですよ
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220003")


	--★★マーリン★★:時間をかけ、手間をかけ<br>香り立つ瞬間を待っている
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220004")

-- ▼直接出力
 --PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:その一瞬は<br>ここでしか味わえませんから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220005")

-- ▼直接出力
CloseTalkWindow()
keep_ik_lookat(Actor004,Actor003,"J_Head")
EntryWalk_2P(Actor001,Camera001,EntryData111031_01_06,CameraAssetBundleName111031_01,CameraPos111031_01_106,Actor003,CharaPos111031_01_008,CharaPos111031_01_108)
turn(Actor004,0,-173.536, 0,0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:いらっしゃいアーサー、ノワールくん<br>歓迎はするけれど学園には帰らないわよ
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220007")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:要求を聞こう、義姉さん
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220008")

-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力

	--★★モルガン★★:繰り返しお願いしていることよ<br>「もう戦わないで」
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("アーサー", "否定")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Normal")

	--★★アーサー★★:それは聞けんな！！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","N","MA_01A111_220010")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor003,"Normal")
	on_cutin(2,Actor004,"Smile")

	--★★モルガン★★:はい終了～<br>閉店で～す
	Talk(Actor004,"CHRNAME_MORGAN","speech","N","MA_01A111_220011")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	on_cutin(1,Actor003,"Sad")
	on_cutin(2,Actor004,"Smile")

	--★★アーサー★★:うわあ！た、頼む！もう１回チャンスをくれー！<br>俺が悪かったよ義姉さん！！開店してくれ～！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","N","MA_01A111_220012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
	close_cutin()
	change_face(Actor004,"Normal")

	--★★モルガン★★:次は総力戦、死にに行くようなものよ<br>貴方を止める理由…わかるわよね？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220013")

-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★モルガン★★:…どうしてＧＳをしないの、アーサー？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力


-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	close_cutin()

	--★★モルガン★★:それでも学園のために身を捧げんとしてる<br>貴方は歪んでる、そして揺れている…違う？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220016")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:アーサーが、ＧＳをしていない…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_220017")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:王家に代々伝わる剣があります<br>ＧＳをせずとも…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★モルガン★★:アーサーが卓越した力を持っていることは<br>誰の目にも明らか。だけど今のままでは…
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220019")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:王は、特定の誰かと絆を結ぼうとしません<br>この学園のすべてを守りたいというお人ですから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それは、本当の理由ですか…？<br>キラーズなしでバルバロイと戦い続けて──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_220021")

	change_face(Actor003,"Normal")

	--★★アーサー★★:………
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220023")

-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:学園が貴方になにかしてくれた？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220024")

	PlayAction(Actor004,"to  Std_No")

	--★★モルガン★★:その博愛は与えられた者が喰らうだけ<br>愛は返って来ずに、貴方だけが傷つき続ける
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★モルガン★★:拙きを学園にかくまい、弱きを守り<br>周囲への気配りと徒労ばかりで
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220026")

	PlayAction(Actor004,"to  Std_Talk")

	--★★モルガン★★:傷つき続けたその笑顔の裏で貴方は<br>本当はなにを──…
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220028")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:見返りを求められるような命じゃないだろう？<br>俺は、産まれた時から
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220030")

-- ▼直接出力
 --PlayPartVoice("モルガン", "激怒")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★モルガン★★:…愛しい貴方の長生きを願うのが<br>そんなにおかしい…？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220031")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アーサー★★:父から遺されたものが重すぎて<br>今にも潰されてしまいそうだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220032")

	change_face(Actor003,"Normal")

	--★★アーサー★★:学園に溢れる笑顔が見たいんだよ<br>それをせめてもの慰めにしたっていいだろう？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220034")


	--★★アーサー★★:そのかけがえのない思い出は必ずや<br>皆が未来まで戦い抜く礎となるはずだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220035")


	--★★アーサー★★:そうして王として生きるんだ<br>己を尊重する必要はないんだよ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220037")

-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マーリン★★:…！
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220038")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モルガン", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:…そう、貴方はそういう人よね<br>私の言葉なんてどうでも…
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:『楽園』なんてどこにもないよ、義姉さん
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220040")


	--★★アーサー★★:だから力を尽くす
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220042")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:義姉さんが安心して座っていられる<br>そんな居場所にできるように
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A111_220045","MA_01A111_220046","MA_01A111_220047")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:『楽園』…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_220049")

-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:言葉ほど楽しい場所ではありませんよ<br>恐らくですが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マーリン★★:その存在は間もなく知ることになるでしょう<br>貴方はまず来たる戦いに目を向けていてください
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220051")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:王を守るのが騎士の務めです<br>アーサーは円卓が守ります
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_220053")

-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★モルガン★★:…信じていいの？ノワールくん
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:必ず
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_220055")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:円卓の騎士に任せてもらって<br>アーサーには休んでいてもらおう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_220057")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "怒り")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アーサー★★:ノワール～<br>今が働き盛りだというのに
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220058")

-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:そう思い込んでいる人ほど<br>心身を壊しがちなんですよ、アーサー様
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220059")

	goto Block1end

::Block1end::
	change_face(Actor004,"Anger")

	--★★モルガン★★:ひとつ約束して<br>…次の戦いには出ないで
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220061")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:アーサー様…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A111_220062")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:………わかった、約束しよう
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01A111_220063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルガン★★:おいしいお茶が入ったの<br>一息ついたら、そうしたらアーサー…
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220065")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:私を学園へ連れて行って？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A111_220066")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
