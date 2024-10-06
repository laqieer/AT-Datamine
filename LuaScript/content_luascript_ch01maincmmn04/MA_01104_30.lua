-- このluaスクリプトは、MA_01104_30.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_03","110141_03_h")
Include("content_adv_advsmall_110141_03","Template110141_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_03,CameraPos110141_03_001)
	InitializeTemplateRandomCamera110141_03()
	InitializeTemplate110141_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()


	--★★マルディサント★★:せっかくご足労をおかけしたにも関わらず<br>誠に心苦しいのですが
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300002")


	--★★マルディサント★★:ディナタン様とは<br>ご縁が結べない結論に達しました
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:ディナタン様の今後のご活躍を<br>心よりお祈り申し上げます
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★モルガン★★:意地悪言わないの<br>いきなりお祈りしないの
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300005")


	--★★マルディサント★★:門前払いってヤツだよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300006")

	change_face(Actor001,"Anger")

	--★★ディナタン★★:お願いします
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_300007")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:ここで働かせてください
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_300009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:…あのね。ここは普通の学校じゃないわ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300010")


	--★★モルガン★★:療養院に来る子たちも<br>普通のケガばかりとは限らない
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300011")

	change_face(Actor003,"Sad")

	--★★モルガン★★:見なくていいもの<br>たくさん見ることになるのよ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:覚悟はあります<br>ずっとそうでした
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_300013")

	change_face(Actor001,"Sad")

	--★★ディナタン★★:傭兵団にいたころから<br>みんなの怪我の処置なら──
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_300014")

	change_face(Actor002,"Anger")

	--★★マルディサント★★:間に合わせの技術で<br>モルガンせんせのツラに泥塗ろうって？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300015")

	PlayAction(Actor003,"to  Std_Talk")

	--★★モルガン★★:マルディサント<br>圧迫面接は良くないわね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:モルガンせんせにはさ<br>アタシひとりいりゃいいじゃん
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300017")

	change_face(Actor003,"Normal")

	--★★モルガン★★:その心は？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300018")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★マルディサント★★:こんな奴に入り浸られたら<br>アタシの安息が乱される！！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モルガン★★:じゃ採用―っ！！
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300021")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:ゲッホゲホッ！？！？ええええーー！？<br>えほっ、げほっ！？ええええーいやだよー！！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300023")

	change_face(Actor003,"Surprise")

	--★★モルガン★★:マルディサント、大丈夫？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300024")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:いやだよー！！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★モルガン★★:ふふ、よろしくね。ディナタン
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ディナタン★★:が、がんばります…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01104_300028")

	change_face(Actor002,"Surprise")

	--★★マルディサント★★:なんでだよモルガンせんせ！？<br>その心はー！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:忙しくなるもの<br>特にこれからはね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300030")

	change_face(Actor003,"Smile")

	--★★モルガン★★:人手が増えるのは大歓迎よ<br>良い働き手なら特にね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300031")

	change_face(Actor003,"Sad")

	--★★モルガン★★:誰かさんは寝てばっかりで<br>ぜーんぜん手伝ってくれないし
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01104_300032")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Pain")

	--★★マルディサント★★:ぐうの音も出ねえな！！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01104_300034")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
